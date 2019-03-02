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

	public partial class FactStrategyPlan : XPLiteObject
	{
		int fStrategyPlanKey;
		[Key(true)]
		public int StrategyPlanKey
		{
			get
			{
				return fStrategyPlanKey;
			}
			set
			{
				SetPropertyValue<int>(nameof(StrategyPlanKey), ref fStrategyPlanKey, value);
			}
		}
		Date fDatekey;
		[Association(@"FactStrategyPlanReferencesDate")]
		public Date Datekey
		{
			get
			{
				return fDatekey;
			}
			set
			{
				SetPropertyValue<Date>(nameof(Datekey), ref fDatekey, value);
			}
		}
		Entity fEntityKey;
		[Association(@"FactStrategyPlanReferencesEntity")]
		public Entity EntityKey
		{
			get
			{
				return fEntityKey;
			}
			set
			{
				SetPropertyValue<Entity>(nameof(EntityKey), ref fEntityKey, value);
			}
		}
		Scenario fScenarioKey;
		[Association(@"FactStrategyPlanReferencesScenario")]
		public Scenario ScenarioKey
		{
			get
			{
				return fScenarioKey;
			}
			set
			{
				SetPropertyValue<Scenario>(nameof(ScenarioKey), ref fScenarioKey, value);
			}
		}
		Account fAccountKey;
		[Association(@"FactStrategyPlanReferencesAccount")]
		public Account AccountKey
		{
			get
			{
				return fAccountKey;
			}
			set
			{
				SetPropertyValue<Account>(nameof(AccountKey), ref fAccountKey, value);
			}
		}
		Currency fCurrencyKey;
		[Association(@"FactStrategyPlanReferencesCurrency")]
		public Currency CurrencyKey
		{
			get
			{
				return fCurrencyKey;
			}
			set
			{
				SetPropertyValue<Currency>(nameof(CurrencyKey), ref fCurrencyKey, value);
			}
		}
		ProductCategory fProductCategoryKey;
		[Association(@"FactStrategyPlanReferencesProductCategory")]
		public ProductCategory ProductCategoryKey
		{
			get
			{
				return fProductCategoryKey;
			}
			set
			{
				SetPropertyValue<ProductCategory>(nameof(ProductCategoryKey), ref fProductCategoryKey, value);
			}
		}
		decimal fAmount;
		public decimal Amount
		{
			get
			{
				return fAmount;
			}
			set
			{
				SetPropertyValue<decimal>(nameof(Amount), ref fAmount, value);
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
	}

}
