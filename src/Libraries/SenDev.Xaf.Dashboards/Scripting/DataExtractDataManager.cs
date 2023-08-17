﻿using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Threading;
using DevExpress.DashboardCommon;
using DevExpress.ExpressApp;
using SenDev.Xaf.Dashboards.BusinessObjects;
using SenDev.Xaf.Dashboards.Utils;

namespace SenDev.Xaf.Dashboards.Scripting
{
	public class DataExtractDataManager
	{

		public DataExtractDataManager(XafApplication application)
		{
			Application = application;
		}

		private XafApplication Application
		{
			get;
		}

		public void UpdateAllExtracts() => UpdateAllExtracts(CancellationToken.None);
		public void UpdateAllExtracts(CancellationToken cancellationToken)
		{
			using (var objectSpace = Application.CreateObjectSpace())
			{
				var extracts = objectSpace
					.GetObjects(SenDevDashboardsModule.GetDashboardDataExtractType(Application))
					.Cast<IDashboardDataExtract>();

				foreach (var extract in extracts)
				{
					cancellationToken.ThrowIfCancellationRequested();
					UpdateDataExtract(extract, cancellationToken);
					objectSpace.CommitChanges();
				}
			}
		}

		public void UpdateDataExtractByKey(object key) => UpdateDataExtractByKey(key, CancellationToken.None);
		public void UpdateDataExtractByKey(object key, CancellationToken cancellationToken)
		{
			if (key == null)
				throw new ArgumentNullException(nameof(key));

			using (var objectSpace = Application.CreateObjectSpace())
			{
				var extract = DashboardHelper.GetDataExtract(Application, objectSpace, key);
				if (extract == null)
				{
					throw new ArgumentException($"No DashboardExtract found for the key '{key}'", nameof(key));
				}

				UpdateDataExtract(extract, cancellationToken);
				objectSpace.CommitChanges();
			}
		}
		private void UpdateDataExtract(IDashboardDataExtract extract, CancellationToken cancellationToken)
		{
			if (extract == null)
				throw new ArgumentNullException(nameof(extract));
			if (string.IsNullOrWhiteSpace(extract.Script))
				return;


			ScriptDataSource dataSource = CreateScriptDataSource(extract, Application, cancellationToken);
			object data = dataSource.GetDataForDataExtract();
			if (data == null)
			{
				extract.ExtractData = null;
				extract.RowCount = 0;
				return;
			}
			using (DashboardObjectDataSource ods = new DashboardObjectDataSource())
			{

				if (data is byte[] buffer)
				{
					SetDataExtractContent(extract, buffer);
					return;
				}
				ods.DataSource = data;
				string fileName = Path.GetTempFileName();
				try
				{
					using (DashboardExtractDataSource extractDataSource = new DashboardExtractDataSource())
					{
						extractDataSource.ExtractSourceOptions.DataSource = ods;
						extractDataSource.FileName = fileName;
						extractDataSource.UpdateExtractFile(cancellationToken);
						SetDataExtractContent(extract, File.ReadAllBytes(fileName));
						if (data is ICollection collection)
							extract.RowCount = collection.Count;
					}
				}
				finally
				{
					if (File.Exists(fileName))
						File.Delete(fileName);
				}

			}
		}

		protected virtual ScriptDataSource CreateScriptDataSource(IDashboardDataExtract extract, XafApplication application, CancellationToken cancellationToken) =>
			new ScriptDataSource(extract.Script, cancellationToken) { Application = application };

		private static void SetDataExtractContent(IDashboardDataExtract extract, byte[] fileData)
		{
			extract.ExtractData = fileData;
			extract.ExtractDataSize = extract.ExtractData.LongLength;
		}
	}
}
