﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace SenDev.DashboardsDemo.Module.BusinessObjects
{

	[Persistent(@"DimChannel")]
	public partial class Channel : XPLiteObject
	{
		int fChannelKey;
		[Key(true)]
		public int ChannelKey
		{
			get
			{
				return fChannelKey;
			}
			set
			{
				SetPropertyValue<int>(nameof(ChannelKey), ref fChannelKey, value);
			}
		}
		string fChannelLabel;
		public string ChannelLabel
		{
			get
			{
				return fChannelLabel;
			}
			set
			{
				SetPropertyValue<string>(nameof(ChannelLabel), ref fChannelLabel, value);
			}
		}
		string fChannelName;
		[Size(20)]
		public string ChannelName
		{
			get
			{
				return fChannelName;
			}
			set
			{
				SetPropertyValue<string>(nameof(ChannelName), ref fChannelName, value);
			}
		}
		string fChannelDescription;
		[Size(50)]
		public string ChannelDescription
		{
			get
			{
				return fChannelDescription;
			}
			set
			{
				SetPropertyValue<string>(nameof(ChannelDescription), ref fChannelDescription, value);
			}
		}
		int fETLLoadID;
		public int ETLLoadID
		{
			get
			{
				return fETLLoadID;
			}
			set
			{
				SetPropertyValue<int>(nameof(ETLLoadID), ref fETLLoadID, value);
			}
		}
		DateTime fLoadDate;
		public DateTime LoadDate
		{
			get
			{
				return fLoadDate;
			}
			set
			{
				SetPropertyValue<DateTime>(nameof(LoadDate), ref fLoadDate, value);
			}
		}
		DateTime fUpdateDate;
		public DateTime UpdateDate
		{
			get
			{
				return fUpdateDate;
			}
			set
			{
				SetPropertyValue<DateTime>(nameof(UpdateDate), ref fUpdateDate, value);
			}
		}
		[Association(@"FactSalesReferencesChannel")]
		public XPCollection<Sales> FactSalesCollection
		{
			get
			{
				return GetCollection<Sales>(nameof(FactSalesCollection));
			}
		}
		[Association(@"FactSalesQuotaReferencesChannel")]
		public XPCollection<FactSalesQuota> FactSalesQuotas
		{
			get
			{
				return GetCollection<FactSalesQuota>(nameof(FactSalesQuotas));
			}
		}
	}

}
