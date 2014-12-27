//
// Class	:	SALSalesLineBatchCollection.cs
// Author	:  	Ignyte Software ©  2011 (DLG 2.0.9.0)
// Date		:	12/26/2014 2:45:58 AM
//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;

namespace DAPOS
{
	public class SALSalesLineBatchCollection :Collection<SALSalesLineBatch>, IEnumerable<SALSalesLineBatch>, IComparer
	{
	
		 #region Inner Types
		   
	 
		 /// <summary>
		 /// used as self contained enumerator .
		 /// </summary>
		 public class Enumerator : IEnumerator
		 {
			
			private int position = -1;
			private SALSalesLineBatchCollection t;

			public Enumerator (SALSalesLineBatchCollection t)
			{
				this.t = t;
			}

			// Declare the MoveNext method required by IEnumerator:
			public bool MoveNext()
			{
				if (position < t.Count - 1)
				{
					position++;
					return true;
				}
				else
				{
					return false;
				}
			}

			// Declare the Reset method required by IEnumerator:
			public void Reset()
			{
				position = -1;
			}

			// Declare the Current property required by IEnumerator:
			public object Current
			{
				get
				{
					return t[position];
				}
			}
			public void Dispose()
			{
				//nothing
			}
		 }

   
		/// <summary>
		/// used in for general IComparer implemented methods in the project
		/// </summary>
		struct SortKey
		{
		   // Only one of the following fields is used.
		   public FieldInfo FieldInfo;
		   public PropertyInfo PropertyInfo;
		   // true if sort is descending.
		   public bool Descending;
		   /// <summary>
		   /// true if sort is case-insensitive.
		   /// </summary>
		   public bool CaseInsensitive;
		}
		#endregion
	
		#region Class Level Variables
		/// <summary>
		/// the data about each passed sorting key
		/// </summary>
		private SortKey[] sortKeys;
	
		#endregion
		
		#region Constants
		
		#endregion

		#region Constructors / Destructors 
		
		#endregion

		#region Properties

		#endregion

		#region Methods (Public)
		
		/// <summary>
		/// Sorts the internal collection of objects using an SQL-like syntax to indicate 
		/// one or more properties and sort direction such as 'PropertyName DESC, PropertyName2 ASC, ...'"
		/// </summary>
		/// <param name="sortingExpression" type ="string">the SQL-like sorting expression</param>
		public void Sort(string sortingExpression)
		{
			if(this.Items.Count==0)
				return;
			PrepareSorting( sortingExpression);
			SALSalesLineBatch[] elements =new SALSalesLineBatch[this.Items.Count];
			this.Items.CopyTo(elements,0);
			Array.Sort(elements,this);
			//clear old order and copy new order here
			this.Items.Clear();
			foreach(SALSalesLineBatch item in elements)
				this.Items.Add(item);
		}
		
		/// <summary>
		/// Gets the associated enumerator.
		/// </summary>
		/// <returns>the associated enumerator</returns>
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new SALSalesLineBatchCollection.Enumerator(this);
		}
		
		/// <summary>
		/// compares 2 objects
		/// </summary>
		/// <param name="o1" type="string">first object</param>
		/// <param name="o2" type="string">2nd object</param>
		/// <returns>zero if equal ,negative if this object is smaller, positive otherwise</returns>
		public int Compare( object o1,  object o2)
		{
			// Deal with simplest cases first.
			if ( o1 == null )
			{
				// Two null objects are equal.
				if ( o2 == null )
					return 0;
				// A null object is less than any non-null object.
				return -1;
			}
			else if ( o2 == null )
			{
				// Any non-null object is greater than a null object.
				return 1;
			}

			// Iterate over all the sort keys.
			for ( int i = 0 ; i < sortKeys.Length; i++ )
			{
				object value1, value2;
				// Read either the field or the property.
				if ( sortKeys[i].FieldInfo != null )
				{
					value1 = sortKeys[i].FieldInfo.GetValue(o1);
					value2 = sortKeys[i].FieldInfo.GetValue(o2);
				}
				else
				{
					value1 = sortKeys[i].PropertyInfo.GetValue(o1, null);
					value2 = sortKeys[i].PropertyInfo.GetValue(o2, null);
				}

				int res;
				if ( value1 == null && value2 == null )
				{
					// Two null objects are equal.
					res = 0;
				}
				else if ( value1 == null )
				{
					// A null object is always less than a non-null object.
					res = -1;
				}
				else if ( value2 == null )
				{
					// Any object is greater than a null object.
					res = 1;
				}
				else if (! sortKeys[i].CaseInsensitive )
				{
					// Compare the two values, assuming that they support IComparable.
					res = (value1 as IComparable).CompareTo(value2);
				}
				else
				{
					// if TEXT qualifier was used, compare strings in case-insensitive mode.
					res = String.Compare(value1.ToString(), value2.ToString(), true);
				}

				// if ( values are different, return this value to caller.
				if ( res != 0 )
				{
					// Reverse it if sort direction is descending.
					if ( sortKeys[i].Descending )
						res = -res;
					return res;
				}
			}
			// if we get here the two objects are equal.
			return 0;
		}
		#endregion
		
		#region Methods (Private)
		/// <summary>
		/// Prepares the sorting data based on sorting expression
		/// </summary>
		/// <param name="sortingExpression" type="string">sorting expression a comma serparated values of
		/// (field_name [desc])</param>
		private void PrepareSorting(string sortingExpression)
		{
			if (this.Items.Count == 0) return;
			Type type =this[0].GetType();
			// Split the list of properties.
			string[] props = sortingExpression.Split(',');
			// Prepare the array that holds information on sort criteria.
			sortKeys = new SortKey[props.Length];

			// Parse the sort string.
			for ( int i = 0; i < props.Length; i++ )
			{
				// Get the N-th member name.
				string memberName = props[i].Trim();
				if ( memberName.ToLower().EndsWith(" desc") )
				{
					// Discard the DESC qualifier if found.
					sortKeys[i].Descending = true;
					memberName = memberName.Substring(0, memberName.Length - 5).TrimEnd();
				}
				if ( memberName.ToLower().EndsWith(" text") )
				{
					// Discard the TEXT qualifier if found.
					sortKeys[i].CaseInsensitive = true;
					memberName = memberName.Substring(0, memberName.Length - 5).TrimEnd();
				}
				// Search for a field with this name.
				sortKeys[i].FieldInfo = type.GetField(memberName);
				if ( sortKeys[i].FieldInfo == null )
				{
					// if not found, search for a property with this name.
					sortKeys[i].PropertyInfo = type.GetProperty(memberName);
				}
			}
		}
		
	 #endregion
		
	}
}
