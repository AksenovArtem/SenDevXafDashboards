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

	[Persistent(@"DimProduct")]
	public partial class Product : XPLiteObject
	{
		int fProductKey;
		[Key(true)]
		public int ProductKey
		{
			get
			{
				return fProductKey;
			}
			set
			{
				SetPropertyValue<int>(nameof(ProductKey), ref fProductKey, value);
			}
		}
		string fProductLabel;
		[Size(255)]
		public string ProductLabel
		{
			get
			{
				return fProductLabel;
			}
			set
			{
				SetPropertyValue<string>(nameof(ProductLabel), ref fProductLabel, value);
			}
		}
		string fProductName;
		[Size(500)]
		public string ProductName
		{
			get
			{
				return fProductName;
			}
			set
			{
				SetPropertyValue<string>(nameof(ProductName), ref fProductName, value);
			}
		}
		string fProductDescription;
		[Size(400)]
		public string ProductDescription
		{
			get
			{
				return fProductDescription;
			}
			set
			{
				SetPropertyValue<string>(nameof(ProductDescription), ref fProductDescription, value);
			}
		}
		ProductSubcategory fProductSubcategoryKey;
		[Association(@"ProductReferencesProductSubcategory")]
		public ProductSubcategory ProductSubcategoryKey
		{
			get
			{
				return fProductSubcategoryKey;
			}
			set
			{
				SetPropertyValue<ProductSubcategory>(nameof(ProductSubcategoryKey), ref fProductSubcategoryKey, value);
			}
		}
		string fManufacturer;
		[Size(50)]
		public string Manufacturer
		{
			get
			{
				return fManufacturer;
			}
			set
			{
				SetPropertyValue<string>(nameof(Manufacturer), ref fManufacturer, value);
			}
		}
		string fBrandName;
		[Size(50)]
		public string BrandName
		{
			get
			{
				return fBrandName;
			}
			set
			{
				SetPropertyValue<string>(nameof(BrandName), ref fBrandName, value);
			}
		}
		string fClassID;
		[Size(10)]
		public string ClassID
		{
			get
			{
				return fClassID;
			}
			set
			{
				SetPropertyValue<string>(nameof(ClassID), ref fClassID, value);
			}
		}
		string fClassName;
		[Size(20)]
		public string ClassName
		{
			get
			{
				return fClassName;
			}
			set
			{
				SetPropertyValue<string>(nameof(ClassName), ref fClassName, value);
			}
		}
		string fStyleID;
		[Size(10)]
		public string StyleID
		{
			get
			{
				return fStyleID;
			}
			set
			{
				SetPropertyValue<string>(nameof(StyleID), ref fStyleID, value);
			}
		}
		string fStyleName;
		[Size(20)]
		public string StyleName
		{
			get
			{
				return fStyleName;
			}
			set
			{
				SetPropertyValue<string>(nameof(StyleName), ref fStyleName, value);
			}
		}
		string fColorID;
		[Size(10)]
		public string ColorID
		{
			get
			{
				return fColorID;
			}
			set
			{
				SetPropertyValue<string>(nameof(ColorID), ref fColorID, value);
			}
		}
		string fColorName;
		[Size(20)]
		public string ColorName
		{
			get
			{
				return fColorName;
			}
			set
			{
				SetPropertyValue<string>(nameof(ColorName), ref fColorName, value);
			}
		}
		string fSize;
		[Size(50)]
		public string Size
		{
			get
			{
				return fSize;
			}
			set
			{
				SetPropertyValue<string>(nameof(Size), ref fSize, value);
			}
		}
		string fSizeRange;
		[Size(50)]
		public string SizeRange
		{
			get
			{
				return fSizeRange;
			}
			set
			{
				SetPropertyValue<string>(nameof(SizeRange), ref fSizeRange, value);
			}
		}
		string fSizeUnitMeasureID;
		[Size(20)]
		public string SizeUnitMeasureID
		{
			get
			{
				return fSizeUnitMeasureID;
			}
			set
			{
				SetPropertyValue<string>(nameof(SizeUnitMeasureID), ref fSizeUnitMeasureID, value);
			}
		}
		double fWeight;
		public double Weight
		{
			get
			{
				return fWeight;
			}
			set
			{
				SetPropertyValue<double>(nameof(Weight), ref fWeight, value);
			}
		}
		string fWeightUnitMeasureID;
		[Size(20)]
		public string WeightUnitMeasureID
		{
			get
			{
				return fWeightUnitMeasureID;
			}
			set
			{
				SetPropertyValue<string>(nameof(WeightUnitMeasureID), ref fWeightUnitMeasureID, value);
			}
		}
		string fUnitOfMeasureID;
		[Size(10)]
		public string UnitOfMeasureID
		{
			get
			{
				return fUnitOfMeasureID;
			}
			set
			{
				SetPropertyValue<string>(nameof(UnitOfMeasureID), ref fUnitOfMeasureID, value);
			}
		}
		string fUnitOfMeasureName;
		[Size(40)]
		public string UnitOfMeasureName
		{
			get
			{
				return fUnitOfMeasureName;
			}
			set
			{
				SetPropertyValue<string>(nameof(UnitOfMeasureName), ref fUnitOfMeasureName, value);
			}
		}
		string fStockTypeID;
		[Size(10)]
		public string StockTypeID
		{
			get
			{
				return fStockTypeID;
			}
			set
			{
				SetPropertyValue<string>(nameof(StockTypeID), ref fStockTypeID, value);
			}
		}
		string fStockTypeName;
		[Size(40)]
		public string StockTypeName
		{
			get
			{
				return fStockTypeName;
			}
			set
			{
				SetPropertyValue<string>(nameof(StockTypeName), ref fStockTypeName, value);
			}
		}
		decimal fUnitCost;
		public decimal UnitCost
		{
			get
			{
				return fUnitCost;
			}
			set
			{
				SetPropertyValue<decimal>(nameof(UnitCost), ref fUnitCost, value);
			}
		}
		decimal fUnitPrice;
		public decimal UnitPrice
		{
			get
			{
				return fUnitPrice;
			}
			set
			{
				SetPropertyValue<decimal>(nameof(UnitPrice), ref fUnitPrice, value);
			}
		}
		DateTime fAvailableForSaleDate;
		public DateTime AvailableForSaleDate
		{
			get
			{
				return fAvailableForSaleDate;
			}
			set
			{
				SetPropertyValue<DateTime>(nameof(AvailableForSaleDate), ref fAvailableForSaleDate, value);
			}
		}
		DateTime fStopSaleDate;
		public DateTime StopSaleDate
		{
			get
			{
				return fStopSaleDate;
			}
			set
			{
				SetPropertyValue<DateTime>(nameof(StopSaleDate), ref fStopSaleDate, value);
			}
		}
		string fStatus;
		[Size(7)]
		public string Status
		{
			get
			{
				return fStatus;
			}
			set
			{
				SetPropertyValue<string>(nameof(Status), ref fStatus, value);
			}
		}
		string fImageURL;
		[Size(150)]
		public string ImageURL
		{
			get
			{
				return fImageURL;
			}
			set
			{
				SetPropertyValue<string>(nameof(ImageURL), ref fImageURL, value);
			}
		}
		string fProductURL;
		[Size(150)]
		public string ProductURL
		{
			get
			{
				return fProductURL;
			}
			set
			{
				SetPropertyValue<string>(nameof(ProductURL), ref fProductURL, value);
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
		[Association(@"FactInventoryReferencesProduct")]
		public XPCollection<FactInventory> FactInventories
		{
			get
			{
				return GetCollection<FactInventory>(nameof(FactInventories));
			}
		}
		[Association(@"FactOnlineSalesReferencesProduct")]
		public XPCollection<FactOnlineSales> FactOnlineSalesCollection
		{
			get
			{
				return GetCollection<FactOnlineSales>(nameof(FactOnlineSalesCollection));
			}
		}
		[Association(@"FactSalesReferencesProduct")]
		public XPCollection<Sales> FactSalesCollection
		{
			get
			{
				return GetCollection<Sales>(nameof(FactSalesCollection));
			}
		}
		[Association(@"FactSalesQuotaReferencesProduct")]
		public XPCollection<FactSalesQuota> FactSalesQuotas
		{
			get
			{
				return GetCollection<FactSalesQuota>(nameof(FactSalesQuotas));
			}
		}
	}

}
