﻿/* Title:       Production Project Classs
 * Date:        1-4-20
 * Author:      Terry Holmes
 * 
 * Description: This is used for production projects */

using NewEventLogDLL;
using ProductionProjectDLL.FindOpenProductionProjectUndergroundDataSetTableAdapters;
using System;

namespace ProductionProjectDLL
{
    public class ProductionProjectClass
    {
        //setting up the classes
        EventLogClass TheEventLogClass = new EventLogClass();

        ProductionProjectsDataSet aProductionProjectsDataSet;
        ProductionProjectsDataSetTableAdapters.productionprojectsTableAdapter aProductionProjectsTableAdapter;

        InsertProductionProjectEntryTableAdapters.QueriesTableAdapter aInsertProductionProjectTableAdapter;

        UpdateProductionProjectStatusEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectStatusTableAdapter;

        FindProdutionProjectsByAssignedProjectIDDataSet aFindProductionProjectsByAssignedProjectIDDataSet;
        FindProdutionProjectsByAssignedProjectIDDataSetTableAdapters.FindProductionProjectByAssignedProjectIDTableAdapter aFindProductionProjectsByAssignedProjectsIDTableAdapter;

        FindOpenProductionProjectsDataSet aFindOpenProductionProjectsDataSet;
        FindOpenProductionProjectsDataSetTableAdapters.FindOpenProductionProjectsTableAdapter aFindOpenProductionProjectsTableAdapter;

        FindProductionProjectsByCurrentStatusIDDataSet aFindProductionProjectsByCurrentStatusIDDataSet;
        FindProductionProjectsByCurrentStatusIDDataSetTableAdapters.FindProductionProjectsByCurrentStatusIDTableAdapter aFindProductionProjectsByCurrentStatusIDTableAdapter;

        FindProductionProjectByProjectIDDataSet aFindProductionProjectByProjectIDDataSet;
        FindProductionProjectByProjectIDDataSetTableAdapters.FindProductionProjectByProjectIDTableAdapter aFindProductionProjectByProjectIDTableAdapter;

        UpdateProductionProjectTableAdapterTableAdapters.QueriesTableAdapter aUpdateProductionProjectTableAdapter;

        ProductionProjectInfoDataSet aProductionProjectInfoDataSet;
        ProductionProjectInfoDataSetTableAdapters.productionprojectinfoTableAdapter aProductionProjectInfoTableAdapter;

        InsertProductionProjectInfoEntryTableAdapters.QueriesTableAdapter aInsertProductionProjectInfoTableAdapter;

        UpdateProductionProjectInfoPOAmountEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectInfoPOAmountTableAdapter;

        UpdateProductionProjectInfoSplicingCompleteEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectInfoSplicingCompleteTableAdapter;

        UpdateProductionProjectInfoHardRestorationEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectInfoHardRestorationTableAdapter;

        UpdateProductionProjectInfoQCPerformedEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectInfoQCPerformedTableAdapter;

        RemoveProductionProjectInfoEntryTableAdapters.QueriesTableAdapter aRemoveProductionProjectInfoTableAdapter;

        FindProductionProjectInfoDataSet aFindProductionProjectInfoDataSet;
        FindProductionProjectInfoDataSetTableAdapters.FindProductionProjectInfoTableAdapter aFindProductionProjectInfoTableAdapter;

        FindProductionProjectInfoNeedingSplicingDataSet aFindProductionProjectInfoNeedingSplicingDataSet;
        FindProductionProjectInfoNeedingSplicingDataSetTableAdapters.FindProductionProjectsNeedingSplicingTableAdapter aFindProductionProjectInfoNeedingSplicingTableAdapter;

        FindProductionProjectInfoNeedingQCDataSet aFindProductionProjectInfoNeedingQCDataSet;
        FindProductionProjectInfoNeedingQCDataSetTableAdapters.FindProductionProjectInfoNeedingQCTableAdapter aFindProductionProjectInfoNeedingQCTableAdapter;

        FindProductionProjectInfoPOAmountDataSet aFindProductionProjectInfoPOAmountDataSet;
        FindProductionProjectInfoPOAmountDataSetTableAdapters.FindProductionProjectInfoPOAmountTableAdapter aFindProductionProjectInfoPOAmountTableAdapter;

        ProductionProjectCableDataSet aProductionProjectCableDateSet;
        ProductionProjectCableDataSetTableAdapters.productionprojectcableTableAdapter aProductionProjectCableTableAdapter;

        InsertProductionProjectCableEntryTableAdapters.QueriesTableAdapter aInsertProductionProjectCableTableAdapter;

        UpdateProductionProjectCableFootageEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectCableFootageTableAdapter;

        UpdateProductionProjectCableTypeEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectCableTypeTableAdapter;

        RemoveProductionProjectCableEntryTableAdapters.QueriesTableAdapter aRemoveProductionProjectCableTableAdapter;

        UpdateProductionProjectCablePartIDEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectCablePartIDTableAdapter;

        FindProductionProjectCableByProjectIDDataSet aFindProductionProjectCableByProjectIDDataSet;
        FindProductionProjectCableByProjectIDDataSetTableAdapters.FindProductionProjectCableByProjectIDTableAdapter aFindProductionProjectCableByProjectIDTableAdapter;

        FindProductionProjectCableTotalByProjectIDDataSet aFindProductionProjectCableTotalsByProjectIDDataSet;
        FindProductionProjectCableTotalByProjectIDDataSetTableAdapters.FindProductionProjectCableTotalsByProjectIDTableAdapter aFindProductionProjectCableTotalsByProjectIDTableAdapter;

        ProductionProjectInvoicingDataSet aProductionProjectInvoicingDataSet;
        ProductionProjectInvoicingDataSetTableAdapters.productionprojectinvoicingTableAdapter aProductionProjectInvoicingTableAdapter;

        InsertProductionProjectInvoiceEntryTableAdapters.QueriesTableAdapter aInsertProductionProjectInvoiceTableAdapter;

        UpdateProductionProjectInvoiceStatusEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectInvoiceStatusTableAdapter;

        FindOpenDepartmentProductionProjectsDataSet aFindOpenDepartmentProductionProjectsDataSet;
        FindOpenDepartmentProductionProjectsDataSetTableAdapters.FindOpenDepartmentProductionProjectsTableAdapter aFindOpenDepartmentProductionProjectsTableAdapater;

        FindProductionProjectInvoicingTransactionsDataSet aFindProductionProjectInvoicingTransactionsDataSet;
        FindProductionProjectInvoicingTransactionsDataSetTableAdapters.FindProductionProjectInvoiceTransactionsTableAdapter aFindProductionProjectInvoicingTransactionsTableAdapter;

        FindProductionProjectInvoicingTotalByProjectIDDataSet aFindProductionProjectInvoicingTotalByProjectIDDataSet;
        FindProductionProjectInvoicingTotalByProjectIDDataSetTableAdapters.FindProductionProjectInvoicingTotalByProjectIDTableAdapter aFindProductionProjectInvoicingTotalByProjectIDTableAdapter;

        FindProductionProjectInvoicingTotalsByDateRangeDataSet aFindProductionProjectInvoicingTotalsByDateRangeDataSet;
        FindProductionProjectInvoicingTotalsByDateRangeDataSetTableAdapters.FindProductionProjectInvoicingTotalsByDateRangeTableAdapter aFindProductionProjectInvoicingTotalsByDateRangeTableAdapter;

        ProductionProjectDocumentationDataSet aProductionProjectDocumentationDataSet;
        ProductionProjectDocumentationDataSetTableAdapters.productionprojectdocumentationTableAdapter aProductionProjectDocumentationTableAdapter;

        InsertProductionProjectDocumentEntryTableAdapters.QueriesTableAdapter aInsertProductionProjectDocumentationTableAdapter;

        FindProductionProjectDocumentationByProjectIDDataSet aFindProductionProjectDocumentationByProjectIDDataSet;
        FindProductionProjectDocumentationByProjectIDDataSetTableAdapters.FindProductionProjectDocumentationByProjectIDTableAdapter aFindProductionProjectDocumentationByProjectIDTableAdapter;

        InsertProductionProjectUpdateEntryTableAdapters.QueriesTableAdapter aInsertProductionProjectUpdateTableAdapter;

        ProductionProjectUpdatesDataSet aProductionProjectUpdatesDataSet;
        ProductionProjectUpdatesDataSetTableAdapters.productionprojectupdatesTableAdapter aProductionProjectUpdatesTableAdapter;

        FindProductionProjectUpdatesByProjectIDDataSet aFindProductionProjectUpdatesByProjectIDDataSet;
        FindProductionProjectUpdatesByProjectIDDataSetTableAdapters.FindProductionProjectUpdatesByProjectIDTableAdapter aFindProductionProjectUpdatesByProjectIDTableAdapter;

        ProductionProjectQCDataSet aProductionProjectQCDateSet;
        ProductionProjectQCDataSetTableAdapters.productionprojectqcTableAdapter aProductionProjectQCTableAdapter;

        InsertProductionProjectQCEntryTableAdapters.QueriesTableAdapter aInsertProductionProjectQCTableAdapter;

        FindProductionProjectQCByProjectIDDataSet aFindProductionProjectQCByProjectIDDataSet;
        FindProductionProjectQCByProjectIDDataSetTableAdapters.FindProductionProjectQCByProjectIDTableAdapter aFindProductionProjectQCByProjectIDTableAdapter;

        ProductionProjectMaterialRequestDataSet aProductionProjectMaterialRequestDataSet;
        ProductionProjectMaterialRequestDataSetTableAdapters.productionprojectmaterialrequestTableAdapter aProductionProjectMaterialRequestTableAdapter;

        InsertProductionProjectMaterialRequestEntryTableAdapters.QueriesTableAdapter aInsertProductionProjectMaterialRequestTableAdapter;

        FindProductionProjectMaterialRequestDataSet aFindProductionProjectMaterialRequestDataSet;
        FindProductionProjectMaterialRequestDataSetTableAdapters.FindProductionProjectMaterialRequestTableAdapter aFindProductionProjectMaterialRequestTableAdapter;

        ProductionProjectMaterialRequestItemsDataSet aProductionProjectMaterialRequestItemsDataSet;
        ProductionProjectMaterialRequestItemsDataSetTableAdapters.productionprojectmaterialrequestitemsTableAdapter aProductionProjectMaterialRequestItemsTableAdapter;

        InsertProductionProjectMaterialRequestItemsEntryTableAdapters.QueriesTableAdapter aInsertProductionProjectMaterialRequestItemsTableAdapter;

        FindProductionProjectMaterialRequestItemsByRequestDataSet aFindProductionProjectMaterialRequestItemsByRequestDataSet;
        FindProductionProjectMaterialRequestItemsByRequestDataSetTableAdapters.FindProductionProjectMaterailRequestItemsByRequestTableAdapter aFindProductionProjectMaterialRequestItemsByRequestTableAdapter;

        FindProductionProjectMaterialRequestByProjectIDDataSet aFindProductionProjectMaterialRequestItemsByProjectIDDataSet;
        FindProductionProjectMaterialRequestByProjectIDDataSetTableAdapters.FindProductionProjectMaterialRequestItemsByProjectIDTableAdapter aFindProductionProjectMaterialRequestItemsByProjectIDTableAdapter;

        UpdateProductionProjectMaterialRequestDateReceivedEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectMaterialRequestDateReceivedTableAdapter;

        ProductionProjectPermitsDataSet aProductionProjectPermitsDataSet;
        ProductionProjectPermitsDataSetTableAdapters.productionprojectpermitsTableAdapter aProductionProjectPermitsTableAdapter;

        InsertProductionProjectPermitEntryTableAdapters.QueriesTableAdapter aInsertProductionProjectPermitTableAdapter;

        UpdateProductionProjectPermitPermitReceivedEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectPermitReceivedTableAdapter;

        UpdateProductionProjectPermitCostEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectPermitCostTableAdapter;

        FindProductionProjectPermitsByProjectIDDataSet aFindProductionProjectPermitsByProjectIDDataSet;
        FindProductionProjectPermitsByProjectIDDataSetTableAdapters.FindProductionProjectPermitsByProjectIDTableAdapter aFindProductionProjectPermitsByProjectIDTableAdapter;

        ProductionProjectTechAssignedDataSet aProductionProjectTechAssignedDataSet;
        ProductionProjectTechAssignedDataSetTableAdapters.productionprojecttechassignedTableAdapter aProductionProjectTechAssignedTableAdapter;

        InsertProductionProjectTechAssignmentEntryTableAdapters.QueriesTableAdapter aInsertProductionProjectTechAssignmentTableAdapter;

        RemoveProductionProjectTechAssignmentEntryTableAdapters.QueriesTableAdapter aRemoveProductionProjectTechAssignmentTableAdapter;

        FindProductionProjectTechAssignmentsOverDateRangeDataSet aFindProductionProjectTechAssignmentsOverDateRangeDataSet;
        FindProductionProjectTechAssignmentsOverDateRangeDataSetTableAdapters.FindProductionProjectTechnicianAssignmentsOverDateRangeTableAdapter aFindProductionProjectTechAssignmentsOverDateRangeTableAdapter;

        FindProductionProjectTechAssignmentByEmployeeDataSet aFindProductionProjectTechAssignmentByEmployeeDataSet;
        FindProductionProjectTechAssignmentByEmployeeDataSetTableAdapters.FindProductionProjectTechAssignmentByEmployeeTableAdapter aFindProductionProjectTechAssignmentByEmployeeTableAdapter;

        FindProductionProjectTechAssignmentByProjectIDDataSet aFindProductionProjectTechAssignmentByProjectIDDataSet;
        FindProductionProjectTechAssignmentByProjectIDDataSetTableAdapters.FindProductionProjectTechAssignmentByProjectIDTableAdapter aFindProductionProjectTechAssignmentByProjectIDTableAdapter;

        FindOverdueOpenProductionProjectsDataSet aFindOverdueOpenProductionProjectsDataSet;
        FindOverdueOpenProductionProjectsDataSetTableAdapters.FindOverdueOpenProductionProjectsTableAdapter aFindOverdueOpenProductionProjectsTableAdapter;

        FindTotalOpenProductionProjectsDataSet aFindTotalOpenProductionProjectsDataSet;
        FindTotalOpenProductionProjectsDataSetTableAdapters.FindTotalOpenProductionProjectsTableAdapter aFindTotalOpenProductionProjectsTableAdapter;

        FindTotalOpenStatusProjectsDataSet aFindTotalOpenStatusProjectsDataSet;
        FindTotalOpenStatusProjectsDataSetTableAdapters.FindTotalOpenStatusProjectsTableAdapter aFindTotalOpenStatusProjectsTableAdpater;

        FindTotalOverdueProductionProjectsDataSet aFindTotalOverdueProductionProjectsDataSet;
        FindTotalOverdueProductionProjectsDataSetTableAdapters.FindTotalOverdueProductionProjectsTableAdapter aFindTotalOverdueProductionProjectsTableAdapter;

        FindTotalOverdueProjectStatusDataSet aFindTotalOverdueProjectStatusDataSet;
        FindTotalOverdueProjectStatusDataSetTableAdapters.FindTotalOverdueProjectsStatusTableAdapter aFindTotalOverdueProjectStatusTableAdapter;

        FindOverdueProjectsByOfficeBusinessDataSet aFindOverdueProjectsByOfficeBusinessDataSet;
        FindOverdueProjectsByOfficeBusinessDataSetTableAdapters.FindOverdueProjectsByOfficeBusinessTableAdapter aFindOverdueProjectsByOfficeBusinessTableAdapter;

        FindOverdueProjectsByDateRangeDataSet aFindOverdueProjectsByDateRangeDataSet;
        FindOverdueProjectsByDateRangeDataSetTableAdapters.FindOverdueProjectsByDateRangeTableAdapter aFindOverdueProjectsByDateRangeTableAdapter;

        FindOpenOfficeBusinessLineDataSet aFindOpenOfficeBusinessLineDataSet;
        FindOpenOfficeBusinessLineDataSetTableAdapters.FindOpenOfficeBusinessLineProjectsTableAdapter aFindOpenOfficeBusinessLineTableAdapter;

        FindOverdueOfficeBusinesLinesDataSet aFindOverdueOfficeBusinessLinesDataSet;
        FindOverdueOfficeBusinesLinesDataSetTableAdapters.FindOverdueOfficeBusinessLinesTableAdapter aFindOverdueOfficeBusinessLinesTableAdapter;

        FindOpenBusinessLineProjectsForOfficeDataSet aFindOpenBusinessLineProjectsForOfficeDataSet;
        FindOpenBusinessLineProjectsForOfficeDataSetTableAdapters.FindOpenBusinessLineProjectsForOfficeTableAdapter aFindOpenBusinessLineProjectsForOfficeTableAdapter;

        FindOverdueBusinessLineProjectsByOfficeDataSet aFindOverdueBusinessLineProjectsByOfficeDataSet;
        FindOverdueBusinessLineProjectsByOfficeDataSetTableAdapters.FindOverdueBusinessLineProjectsByOfficeTableAdapter aFindOverdueBusinessLineProjectsByOfficeTableAdapter;

        FindInvoicedProductionProjectsDataSet aFindInvoicedProductionProjectsDataSet;
        FindInvoicedProductionProjectsDataSetTableAdapters.FindInvoicedProductionProjectsTableAdapter aFindInvoicedProductionProjectsTableAdapter;

        UpdateProductionProjectInfoPONumberEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectInfoPONumberTableAdapter;

        UpdateProductionProjectInfoJobTypeEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectInfoJobTypeTableAdapter;

        UpdateProductionProjectStatusDateEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectStatusDateEntryTableAdapter;

        FindProductionProjectsEnteredNewStatusDataSet aFindProductionProjectsEnteredNewStatusDataSet;
        FindProductionProjectsEnteredNewStatusDataSetTableAdapters.FindProductionProjectsEnteredNewStatusTableAdapter aFindProductionProjectsEnteredNewStatusTableAdapter;

        FindProductionProjectsNotUpdatedDataSet aFindProductionProjectsNotUpdatedDataSet;
        FindProductionProjectsNotUpdatedDataSetTableAdapters.FindProductionProjectsNotUpdatedTableAdapter aFindProductionProjectsNotUpdatedTableAdapter;

        FindProductionProjectsForDepartmentDataSet aFindProductionProjectsForDepartmentDataSet;
        FindProductionProjectsForDepartmentDataSetTableAdapters.FindProductionProjectsForDepartmentTableAdapter aFindProductionProjectsForDepartmentTableAdapter;

        FindProductionProjectsByDepartmentOfficeDataSet aFindProductionProjectsByDepartmentOfficeDataSet;
        FindProductionProjectsByDepartmentOfficeDataSetTableAdapters.FindProductionProjectsByDepartmentOfficeTableAdapter aFindProductionProjectsByDepartmentOfficeTableAdapter;

        FindProductionProjectsByDepartmentStatusDataSet aFindProductionProjectsByDepartmentStatusDataSet;
        FindProductionProjectsByDepartmentStatusDataSetTableAdapters.FindProductionProjectsByDepartmentStatusTableAdapter aFindProductionProjectsbyDepartmentStatusTableAdapter;

        FindProductionProjectsbyDepartmentStatusOfficeDataSet aFindProductionProjectsbyDepartmentStatusOfficeDataSet;
        FindProductionProjectsbyDepartmentStatusOfficeDataSetTableAdapters.FindProductionProjectsByDepartmentStatusOfficeTableAdapter aFindProductionProjectsbyDepartmentStatusOfficeTableAdapter;

        ProductionProjectNTPDataSet aProductionProjectNTPDataSet;
        ProductionProjectNTPDataSetTableAdapters.productionprojectntpTableAdapter aProductionProjectNTPTableAdapter;

        InsertProductionProjectNTPEntryTableAdapters.QueriesTableAdapter aInsertProductionProjectNTPTableAdapter;

        FindProductionProjectNTPForProjectIDDataSet aFindProductionProjectNTPForProjectIDDataSet;
        FindProductionProjectNTPForProjectIDDataSetTableAdapters.FindProductionProjectNTPForProjectIDTableAdapter aFindProductionProjectNTPForProjectIDTableAdapter;

        FindProductionProjectTotalNTPForProjectIDDataSet aFindProductionProjectTotalNTPForProjectIDDataSet;
        FindProductionProjectTotalNTPForProjectIDDataSetTableAdapters.FindProductionProjectTotalNTPForProjectIDTableAdapter aFindProductionProjectTotalNTPForProjectIDTableAdapter;

        ProductionProjectUndergroundDataSet aProductionProjectUndergroundDataSet;
        ProductionProjectUndergroundDataSetTableAdapters.productionprojectundergroundTableAdapter aProductionProjectUndergroundTableAdapter;

        InsertProductionProjectUndergroundEntryTableAdapters.QueriesTableAdapter aInsertProductionProjectUndergroundTableAdapter;

        UpdateProductionProjectUndergroundDateCompletedEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectUndergroundDateCompletedTableAdapter;

        UpdateProductionProjectUndergroundRestorationCompletedEntryTableAdapters.QueriesTableAdapter aUpdateProductionProductionProjectUndergroundRestorationCompletedTableAdapter;

        FindProductionProjectUndergroundNotCompleteDataSet aFindProductionProjectUndergroundNotCompleteDataSet;
        FindProductionProjectUndergroundNotCompleteDataSetTableAdapters.FindProductionProjectUndergroundNotCompletedTableAdapter aFindProductionProjectUndergroundNotCompleteTableAdapter;

        UpdateProductionProjectUndergroundNeedingRestorationEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectUndergroundNeedingRestorationTableAdapter;

        FindProductionProjectUndergroundNeedingRestorationDataSet aFindProductionProjectUndergroundNeedingRestorationDataSet;
        FindProductionProjectUndergroundNeedingRestorationDataSetTableAdapters.FindProductionProjectUndergroundNeedingRestorationTableAdapter aFindProductionProjectUndergroundNeedingRestorationTableAdapter;

        FindProductionProjectUndergroundByProjectStatusDataSet aFindProductionProjectUndergroundByProjectStatusDataSet;
        FindProductionProjectUndergroundByProjectStatusDataSetTableAdapters.FindProductionProjectUndergroundByProjectStatusTableAdapter aFindProductionProjectUndergroundByProjectStatusTableAdapter;

        FindProductionProjectUndergroundByProjectIDDataSet aFindProductionProjectUndergroundByProjectIDDataSet;
        FindProductionProjectUndergroundByProjectIDDataSetTableAdapters.FindProductionProjectUndergroundByProjectIDTableAdapter aFindProductionProjectUndergroundByProjectIDTableAdapter;

        UpdateProductionProjectUndergroundFootageEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectUndergroundFootageTableAdapter;

        FindOpenProductionProjectUndergroundDataSet aFindOpenProductionProjectUndergroundDataSet;
        FindOpenProductionProjectUndergroundDataSetTableAdapters.FindOpenProductionProjectUndergroundTableAdapter aFindOpenProductionProjectUndergroundTableAdpater;

        UpdateProductionProjectECDDateEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectECDDateTableAdapter;

        UpdateProductionProjectAssignedOfficeEntryTableAdapters.QueriesTableAdapter aUpdateProductionProjectAssignedOfficeTableAdapter;

        FindOpenProductionOutageProjectsDataSet aFindOpenProductionOutageProjectsDataSet;
        FindOpenProductionOutageProjectsDataSetTableAdapters.FindOpenProductionOutageProjectsTableAdapter aFindOpenProductionOutageProjectsTableAdapter;

        public FindOpenProductionOutageProjectsDataSet FindOpenProductionOutageProjects()
        {
            try
            {
                aFindOpenProductionOutageProjectsDataSet = new FindOpenProductionOutageProjectsDataSet();
                aFindOpenProductionOutageProjectsTableAdapter = new FindOpenProductionOutageProjectsDataSetTableAdapters.FindOpenProductionOutageProjectsTableAdapter();
                aFindOpenProductionOutageProjectsTableAdapter.Fill(aFindOpenProductionOutageProjectsDataSet.FindOpenProductionOutageProjects);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Open Production Project Underground " + Ex.ToString());
            }

            return aFindOpenProductionOutageProjectsDataSet;
        }
        public bool UpdateProductionProjectAssignedOffice(int intTransactionID, int intAssignedOfficeID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectAssignedOfficeTableAdapter = new UpdateProductionProjectAssignedOfficeEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectAssignedOfficeTableAdapter.UpdateProductionProjectAssignedOffice(intTransactionID, intAssignedOfficeID);

            }
            catch (Exception Ex)
            {
                blnFatalError = true;
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Assigned Office " + Ex.ToString());
            }
            
            return blnFatalError;
        }
        public bool UpdateProductionProjectECDDate(int intTransactionID, DateTime datECDDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectECDDateTableAdapter = new UpdateProductionProjectECDDateEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectECDDateTableAdapter.UpdateProductionProjectECDDate(intTransactionID, datECDDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project ECD Date " + Ex.ToString());
            }

            return blnFatalError;
        }

        public FindOpenProductionProjectUndergroundDataSet FindOpenProductionProjectUnderground()
        {
            try
            {
                aFindOpenProductionProjectUndergroundDataSet = new FindOpenProductionProjectUndergroundDataSet();
                aFindOpenProductionProjectUndergroundTableAdpater = new FindOpenProductionProjectUndergroundDataSetTableAdapters.FindOpenProductionProjectUndergroundTableAdapter();
                aFindOpenProductionProjectUndergroundTableAdpater.Fill(aFindOpenProductionProjectUndergroundDataSet.FindOpenProductionProjectUnderground);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Open Production Project Underground " + Ex.ToString());
            }

            return aFindOpenProductionProjectUndergroundDataSet;
        }
        public bool UpdateProductionProjectUndergroundFootage(int intProjectID, string strModifiedUser, int intFootage)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectUndergroundFootageTableAdapter = new UpdateProductionProjectUndergroundFootageEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectUndergroundFootageTableAdapter.UpdateProductionProjectUndergroundFootage(intProjectID, strModifiedUser, intFootage);
            }
            catch (Exception Ex)
            {
                blnFatalError = true;

                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Underground Footage " + Ex.ToString());
            }

            return blnFatalError;
        }
        public FindProductionProjectUndergroundByProjectIDDataSet FindProductionProjectUndergroundByProjectID(int intProjectID)
        {
            try
            {
                aFindProductionProjectUndergroundByProjectIDDataSet = new FindProductionProjectUndergroundByProjectIDDataSet();
                aFindProductionProjectUndergroundByProjectIDTableAdapter = new FindProductionProjectUndergroundByProjectIDDataSetTableAdapters.FindProductionProjectUndergroundByProjectIDTableAdapter();
                aFindProductionProjectUndergroundByProjectIDTableAdapter.Fill(aFindProductionProjectUndergroundByProjectIDDataSet.FindProductionProjectUndergroundByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Underground By Project ID " + Ex.ToString());
            }

            return aFindProductionProjectUndergroundByProjectIDDataSet;
        }
        public FindProductionProjectUndergroundByProjectStatusDataSet FindProductionProjectUndergroundByProjectStatus(int intProjectStatus)
        {
            try
            {
                aFindProductionProjectUndergroundByProjectStatusDataSet = new FindProductionProjectUndergroundByProjectStatusDataSet();
                aFindProductionProjectUndergroundByProjectStatusTableAdapter = new FindProductionProjectUndergroundByProjectStatusDataSetTableAdapters.FindProductionProjectUndergroundByProjectStatusTableAdapter();
                aFindProductionProjectUndergroundByProjectStatusTableAdapter.Fill(aFindProductionProjectUndergroundByProjectStatusDataSet.FindProductionProjectUndergroundByProjectStatus, intProjectStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Underground By Project Status " + Ex.ToString());
            }

            return aFindProductionProjectUndergroundByProjectStatusDataSet;
        }
        public FindProductionProjectUndergroundNeedingRestorationDataSet FindProductionProjectUndergroundNeedingRestoration()
        {
            try
            {
                aFindProductionProjectUndergroundNeedingRestorationDataSet = new FindProductionProjectUndergroundNeedingRestorationDataSet();
                aFindProductionProjectUndergroundNeedingRestorationTableAdapter = new FindProductionProjectUndergroundNeedingRestorationDataSetTableAdapters.FindProductionProjectUndergroundNeedingRestorationTableAdapter();
                aFindProductionProjectUndergroundNeedingRestorationTableAdapter.Fill(aFindProductionProjectUndergroundNeedingRestorationDataSet.FindProductionProjectUndergroundNeedingRestoration);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Underground Needing Restoration " + Ex.ToString());
            }

            return aFindProductionProjectUndergroundNeedingRestorationDataSet;
        }
        public bool UpdateProductionProjectUndergroundNeedingRestoration(int intProjectID, string strModifiedUser)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectUndergroundNeedingRestorationTableAdapter = new UpdateProductionProjectUndergroundNeedingRestorationEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectUndergroundNeedingRestorationTableAdapter.UpdateProductionProjectUndergroundNeedingRestoration(intProjectID, strModifiedUser);
            }
            catch (Exception Ex)
            {
                blnFatalError = true;

                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Underground Needing Restoration " + Ex.ToString());
            }

            return blnFatalError;
        }
        public FindProductionProjectUndergroundNotCompleteDataSet FindProductionProjectUndergroundNotComplete()
        {
            try
            {
                aFindProductionProjectUndergroundNotCompleteDataSet = new FindProductionProjectUndergroundNotCompleteDataSet();
                aFindProductionProjectUndergroundNotCompleteTableAdapter = new FindProductionProjectUndergroundNotCompleteDataSetTableAdapters.FindProductionProjectUndergroundNotCompletedTableAdapter();
                aFindProductionProjectUndergroundNotCompleteTableAdapter.Fill(aFindProductionProjectUndergroundNotCompleteDataSet.FindProductionProjectUndergroundNotCompleted);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Underground Not Complete " + Ex.ToString());
            }

            return aFindProductionProjectUndergroundNotCompleteDataSet;
        }
        public bool UpdateProductionProjectUndergroundRestorationCompleted(int intProjectID, string strModifiedUser, DateTime datRestorationCompleteDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProductionProjectUndergroundRestorationCompletedTableAdapter = new UpdateProductionProjectUndergroundRestorationCompletedEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProductionProjectUndergroundRestorationCompletedTableAdapter.UpdateProductionProjectUndergroundRestorationCompleted(intProjectID, strModifiedUser, datRestorationCompleteDate);
            }
            catch (Exception Ex)
            {
                blnFatalError = true;

                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Underground Restoration Completed " + Ex.ToString());
            }

            return blnFatalError;
        }
        public bool UpdateProductionProjectUndergroundDateCompleted(int intProjectID, string strModifiedUser, DateTime datDateCompleted)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectUndergroundDateCompletedTableAdapter = new UpdateProductionProjectUndergroundDateCompletedEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectUndergroundDateCompletedTableAdapter.UpdateProductionProjectUndergroundDateCompleted(intProjectID, strModifiedUser, datDateCompleted);
            }
            catch (Exception Ex)
            {
                blnFatalError = true;

                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Underground Date Completed " + Ex.ToString());
            }

            return blnFatalError;
        }
        public bool InsertProductionProjectUnderground(int intProjectID, string strCreatedUser, int intTotalFootage)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectUndergroundTableAdapter = new InsertProductionProjectUndergroundEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectUndergroundTableAdapter.InsertProductionProjectUnderground(intProjectID, strCreatedUser, intTotalFootage);
            }
            catch (Exception Ex)
            {
                blnFatalError = true;

                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Insert Production Project Underground " + Ex.ToString());
            }

            return blnFatalError;
        }
        public ProductionProjectUndergroundDataSet GetProductionProjectUndergroundInfo()
        {
            try
            {
                aProductionProjectUndergroundDataSet = new ProductionProjectUndergroundDataSet();
                aProductionProjectUndergroundTableAdapter = new ProductionProjectUndergroundDataSetTableAdapters.productionprojectundergroundTableAdapter();
                aProductionProjectUndergroundTableAdapter.Fill(aProductionProjectUndergroundDataSet.productionprojectunderground);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Get Production Project Underground Info " + Ex.ToString());
            }

            return aProductionProjectUndergroundDataSet;
        }
        public void UpdateProductionProjectUndergroundDB(ProductionProjectUndergroundDataSet aProductionProjectUndergroundDataSet)
        {
            try
            {
                aProductionProjectUndergroundTableAdapter = new ProductionProjectUndergroundDataSetTableAdapters.productionprojectundergroundTableAdapter();
                aProductionProjectUndergroundTableAdapter.Update(aProductionProjectUndergroundDataSet.productionprojectunderground);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Underground DB " + Ex.ToString());
            }
        }
        public FindProductionProjectTotalNTPForProjectIDDataSet FindProductionProjectTotalNTPForProjectID(string strCustomerProjectID)
        {
            try
            {
                aFindProductionProjectTotalNTPForProjectIDDataSet = new FindProductionProjectTotalNTPForProjectIDDataSet();
                aFindProductionProjectTotalNTPForProjectIDTableAdapter = new FindProductionProjectTotalNTPForProjectIDDataSetTableAdapters.FindProductionProjectTotalNTPForProjectIDTableAdapter();
                aFindProductionProjectTotalNTPForProjectIDTableAdapter.Fill(aFindProductionProjectTotalNTPForProjectIDDataSet.FindProductionProjectTotalNTPForProjectID, strCustomerProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Total NTP For Project ID " + Ex.ToString());
            }

            return aFindProductionProjectTotalNTPForProjectIDDataSet;
        }
        public FindProductionProjectNTPForProjectIDDataSet FindProductionProjectNTPForProjectID(string strCustomerProjectID)
        {
            try
            {
                aFindProductionProjectNTPForProjectIDDataSet = new FindProductionProjectNTPForProjectIDDataSet();
                aFindProductionProjectNTPForProjectIDTableAdapter = new FindProductionProjectNTPForProjectIDDataSetTableAdapters.FindProductionProjectNTPForProjectIDTableAdapter();
                aFindProductionProjectNTPForProjectIDTableAdapter.Fill(aFindProductionProjectNTPForProjectIDDataSet.FindProductionProjectNTPForProjectID, strCustomerProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project NTP for Project ID " + Ex.ToString());
            }

            return aFindProductionProjectNTPForProjectIDDataSet;
        }
        public bool InsertProductionProjectNTP(string strCreateUserID, string strPONumber, decimal decPOAmount, int intProjectID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectNTPTableAdapter = new InsertProductionProjectNTPEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectNTPTableAdapter.InsertProductionProjectNTP(strCreateUserID, strPONumber, decPOAmount, intProjectID);
            }
            catch (Exception Ex)
            {
                blnFatalError = true;

                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Insert Production Project NTP " + Ex.ToString());
            }

            return blnFatalError;
        }
        public ProductionProjectNTPDataSet GetProductionProjectNTPInfo()
        {
            try
            {
                aProductionProjectNTPDataSet = new ProductionProjectNTPDataSet();
                aProductionProjectNTPTableAdapter = new ProductionProjectNTPDataSetTableAdapters.productionprojectntpTableAdapter();
                aProductionProjectNTPTableAdapter.Fill(aProductionProjectNTPDataSet.productionprojectntp);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Get Production Project NTP Info " + Ex.ToString());
            }

            return aProductionProjectNTPDataSet;
        }
        public void UpdateProductionProjectNTPDB(ProductionProjectNTPDataSet aProductionProjectNTPDataSet)
        {
            try
            {
                aProductionProjectNTPTableAdapter = new ProductionProjectNTPDataSetTableAdapters.productionprojectntpTableAdapter();
                aProductionProjectNTPTableAdapter.Update(aProductionProjectNTPDataSet.productionprojectntp);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project NTP DB " + Ex.ToString());
            }
        }
        public FindProductionProjectsbyDepartmentStatusOfficeDataSet FindProductionProjectsByDepartmentStatusOffice(int intBusinessLineID, int intStatusID, int intOfficeID)
        {
            try
            {
                aFindProductionProjectsbyDepartmentStatusOfficeDataSet = new FindProductionProjectsbyDepartmentStatusOfficeDataSet();
                aFindProductionProjectsbyDepartmentStatusOfficeTableAdapter = new FindProductionProjectsbyDepartmentStatusOfficeDataSetTableAdapters.FindProductionProjectsByDepartmentStatusOfficeTableAdapter();
                aFindProductionProjectsbyDepartmentStatusOfficeTableAdapter.Fill(aFindProductionProjectsbyDepartmentStatusOfficeDataSet.FindProductionProjectsByDepartmentStatusOffice, intBusinessLineID, intOfficeID, intStatusID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Projects Class // Find Production Projects By Department Status Office " + Ex.ToString());
            }

            return aFindProductionProjectsbyDepartmentStatusOfficeDataSet;
        }
        public FindProductionProjectsByDepartmentStatusDataSet FindProductionProjectsByDepartmentStatus(int intBusinessLineID, int intStatusID)
        {
            try
            {
                aFindProductionProjectsByDepartmentStatusDataSet = new FindProductionProjectsByDepartmentStatusDataSet();
                aFindProductionProjectsbyDepartmentStatusTableAdapter = new FindProductionProjectsByDepartmentStatusDataSetTableAdapters.FindProductionProjectsByDepartmentStatusTableAdapter();
                aFindProductionProjectsbyDepartmentStatusTableAdapter.Fill(aFindProductionProjectsByDepartmentStatusDataSet.FindProductionProjectsByDepartmentStatus, intBusinessLineID, intStatusID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Projects Class // Find Production Projects By Department Status " + Ex.ToString());
            }

            return aFindProductionProjectsByDepartmentStatusDataSet;
        }
        public FindProductionProjectsByDepartmentOfficeDataSet FindProductionProjectsByDepartmentOffice (int intBusinessLineID, int intOfficeID)
        {
            try
            {
                aFindProductionProjectsByDepartmentOfficeDataSet = new FindProductionProjectsByDepartmentOfficeDataSet();
                aFindProductionProjectsByDepartmentOfficeTableAdapter = new FindProductionProjectsByDepartmentOfficeDataSetTableAdapters.FindProductionProjectsByDepartmentOfficeTableAdapter();
                aFindProductionProjectsByDepartmentOfficeTableAdapter.Fill(aFindProductionProjectsByDepartmentOfficeDataSet.FindProductionProjectsByDepartmentOffice, intBusinessLineID, intOfficeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Projects Class // Find Production Projects By Department Office " + Ex.ToString());
            }

            return aFindProductionProjectsByDepartmentOfficeDataSet;
        }
        public FindProductionProjectsForDepartmentDataSet FindProductionProjectsForDepartment(int intDepartmentID)
        {
            try
            {
                aFindProductionProjectsForDepartmentDataSet = new FindProductionProjectsForDepartmentDataSet();
                aFindProductionProjectsForDepartmentTableAdapter = new FindProductionProjectsForDepartmentDataSetTableAdapters.FindProductionProjectsForDepartmentTableAdapter();
                aFindProductionProjectsForDepartmentTableAdapter.Fill(aFindProductionProjectsForDepartmentDataSet.FindProductionProjectsForDepartment, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Projects Class // Find Production Projects For Department " + Ex.ToString());
            }

            return aFindProductionProjectsForDepartmentDataSet;
        }
        public FindProductionProjectsNotUpdatedDataSet FindProductionProjectsNotUpdated()
        {
            try
            {
                aFindProductionProjectsNotUpdatedDataSet = new FindProductionProjectsNotUpdatedDataSet();
                aFindProductionProjectsNotUpdatedTableAdapter = new FindProductionProjectsNotUpdatedDataSetTableAdapters.FindProductionProjectsNotUpdatedTableAdapter();
                aFindProductionProjectsNotUpdatedTableAdapter.Fill(aFindProductionProjectsNotUpdatedDataSet.FindProductionProjectsNotUpdated);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // /Find Production Projects Not Updated " + Ex.ToString());
            }

            return aFindProductionProjectsNotUpdatedDataSet;
        }
        public FindProductionProjectsEnteredNewStatusDataSet FindProductionProjectsEnteredNewStatus(int intStatusID, DateTime datStatusChangeDate)
        {
            try
            {
                aFindProductionProjectsEnteredNewStatusDataSet = new FindProductionProjectsEnteredNewStatusDataSet();
                aFindProductionProjectsEnteredNewStatusTableAdapter = new FindProductionProjectsEnteredNewStatusDataSetTableAdapters.FindProductionProjectsEnteredNewStatusTableAdapter();
                aFindProductionProjectsEnteredNewStatusTableAdapter.Fill(aFindProductionProjectsEnteredNewStatusDataSet.FindProductionProjectsEnteredNewStatus, intStatusID, datStatusChangeDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Projects Entered New Status " + Ex.ToString());
            }

            return aFindProductionProjectsEnteredNewStatusDataSet;
        }
        public bool UpdateProductionProjectStatusDate(int intTransactionID, DateTime datChangeStatusDate)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectStatusDateEntryTableAdapter = new UpdateProductionProjectStatusDateEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectStatusDateEntryTableAdapter.UpdateProductionProjectStatusDate(intTransactionID, datChangeStatusDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Status Date // " + Ex.ToString());
            }

            return blnFatalError;
        }
        public bool UpdateProductionProjectInfoJobType(int intTransactionID, int intJobTypeID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectInfoJobTypeTableAdapter = new UpdateProductionProjectInfoJobTypeEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectInfoJobTypeTableAdapter.UpdateProductionProjectInfoJobType(intTransactionID, intJobTypeID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Info Job Type " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateProductionProjectInfoPONumber(int intTransactionID, string strPONumber)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectInfoPONumberTableAdapter = new UpdateProductionProjectInfoPONumberEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectInfoPONumberTableAdapter.UpdateProductionProjectInfoPONumber(intTransactionID, strPONumber);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Info PO Number " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindInvoicedProductionProjectsDataSet FindInvoicedProductionProjects()
        {
            try 
            {
                aFindInvoicedProductionProjectsDataSet = new FindInvoicedProductionProjectsDataSet();
                aFindInvoicedProductionProjectsTableAdapter = new FindInvoicedProductionProjectsDataSetTableAdapters.FindInvoicedProductionProjectsTableAdapter();
                aFindInvoicedProductionProjectsTableAdapter.Fill(aFindInvoicedProductionProjectsDataSet.FindInvoicedProductionProjects);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Invoiced Production Projects " + Ex.ToString());
            }

            return aFindInvoicedProductionProjectsDataSet;
        }
        public FindOverdueBusinessLineProjectsByOfficeDataSet FindOverdueBusinessLineProjectsByOffice(int intWarehouseID, int intDepartmentID, DateTime datTransactionDate)
        {
            try
            {
                aFindOverdueBusinessLineProjectsByOfficeDataSet = new FindOverdueBusinessLineProjectsByOfficeDataSet();
                aFindOverdueBusinessLineProjectsByOfficeTableAdapter = new FindOverdueBusinessLineProjectsByOfficeDataSetTableAdapters.FindOverdueBusinessLineProjectsByOfficeTableAdapter();
                aFindOverdueBusinessLineProjectsByOfficeTableAdapter.Fill(aFindOverdueBusinessLineProjectsByOfficeDataSet.FindOverdueBusinessLineProjectsByOffice, intWarehouseID, intDepartmentID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Overdue Business Line Projects By Office " + Ex.ToString());
            }

            return aFindOverdueBusinessLineProjectsByOfficeDataSet;
        }
        public FindOpenBusinessLineProjectsForOfficeDataSet FindOpenBusinessLineProjectsForOffice(int intWarehouseID, int intDepartmentID)
        {
            try
            {
                aFindOpenBusinessLineProjectsForOfficeDataSet = new FindOpenBusinessLineProjectsForOfficeDataSet();
                aFindOpenBusinessLineProjectsForOfficeTableAdapter = new FindOpenBusinessLineProjectsForOfficeDataSetTableAdapters.FindOpenBusinessLineProjectsForOfficeTableAdapter();
                aFindOpenBusinessLineProjectsForOfficeTableAdapter.Fill(aFindOpenBusinessLineProjectsForOfficeDataSet.FindOpenBusinessLineProjectsForOffice, intWarehouseID, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Open Business Line Projects For Office " + Ex.ToString());
            }

            return aFindOpenBusinessLineProjectsForOfficeDataSet;
        }
        public FindOverdueOfficeBusinesLinesDataSet FindOverdueOfficeBusinessLines(int intOfficeID, int intBusinessLineID, DateTime datTransactionDate)
        {
            try
            {
                aFindOverdueOfficeBusinessLinesDataSet = new FindOverdueOfficeBusinesLinesDataSet();
                aFindOverdueOfficeBusinessLinesTableAdapter = new FindOverdueOfficeBusinesLinesDataSetTableAdapters.FindOverdueOfficeBusinessLinesTableAdapter();
                aFindOverdueOfficeBusinessLinesTableAdapter.Fill(aFindOverdueOfficeBusinessLinesDataSet.FindOverdueOfficeBusinessLines, intOfficeID, intBusinessLineID, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Overdue Office Business Lines " + Ex.ToString());
            }

            return aFindOverdueOfficeBusinessLinesDataSet;
        }
        public FindOpenOfficeBusinessLineDataSet FindOpenOfficeBusinessLine(int intOfficeID, int intBusinessLineID)
        {
            try
            {
                aFindOpenOfficeBusinessLineDataSet = new FindOpenOfficeBusinessLineDataSet();
                aFindOpenOfficeBusinessLineTableAdapter = new FindOpenOfficeBusinessLineDataSetTableAdapters.FindOpenOfficeBusinessLineProjectsTableAdapter();
                aFindOpenOfficeBusinessLineTableAdapter.Fill(aFindOpenOfficeBusinessLineDataSet.FindOpenOfficeBusinessLineProjects, intOfficeID, intBusinessLineID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Open Office Business Line " + Ex.ToString());
            }

            return aFindOpenOfficeBusinessLineDataSet;
        }
        public FindOverdueProjectsByDateRangeDataSet FindOverdueProjectsByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindOverdueProjectsByDateRangeDataSet = new FindOverdueProjectsByDateRangeDataSet();
                aFindOverdueProjectsByDateRangeTableAdapter = new FindOverdueProjectsByDateRangeDataSetTableAdapters.FindOverdueProjectsByDateRangeTableAdapter();
                aFindOverdueProjectsByDateRangeTableAdapter.Fill(aFindOverdueProjectsByDateRangeDataSet.FindOverdueProjectsByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Overdue Projects By Date Range " + Ex.ToString());
            }

            return aFindOverdueProjectsByDateRangeDataSet;
        }
        public FindOverdueProjectsByOfficeBusinessDataSet FindOverdueProjectsByOfficeBusiness(DateTime datTransactionDate)
        {
            try
            {
                aFindOverdueProjectsByOfficeBusinessDataSet = new FindOverdueProjectsByOfficeBusinessDataSet();
                aFindOverdueProjectsByOfficeBusinessTableAdapter = new FindOverdueProjectsByOfficeBusinessDataSetTableAdapters.FindOverdueProjectsByOfficeBusinessTableAdapter();
                aFindOverdueProjectsByOfficeBusinessTableAdapter.Fill(aFindOverdueProjectsByOfficeBusinessDataSet.FindOverdueProjectsByOfficeBusiness, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Overdue Projects By Office Business " + Ex.ToString());
            }

            return aFindOverdueProjectsByOfficeBusinessDataSet;
        }
        public FindTotalOverdueProjectStatusDataSet FindTotalOverdueProjectStatus(DateTime datTransactionDate)
        {
            try
            {
                aFindTotalOverdueProjectStatusDataSet = new FindTotalOverdueProjectStatusDataSet();
                aFindTotalOverdueProjectStatusTableAdapter = new FindTotalOverdueProjectStatusDataSetTableAdapters.FindTotalOverdueProjectsStatusTableAdapter();
                aFindTotalOverdueProjectStatusTableAdapter.Fill(aFindTotalOverdueProjectStatusDataSet.FindTotalOverdueProjectsStatus, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Total Overdue Project Status " + Ex.ToString());
            }

            return aFindTotalOverdueProjectStatusDataSet;
        }
        public FindTotalOverdueProductionProjectsDataSet FindTotalOverdueProductionProjects(DateTime datTransactionDate)
        {
            try
            {
                aFindTotalOverdueProductionProjectsDataSet = new FindTotalOverdueProductionProjectsDataSet();
                aFindTotalOverdueProductionProjectsTableAdapter = new FindTotalOverdueProductionProjectsDataSetTableAdapters.FindTotalOverdueProductionProjectsTableAdapter();
                aFindTotalOverdueProductionProjectsTableAdapter.Fill(aFindTotalOverdueProductionProjectsDataSet.FindTotalOverdueProductionProjects, datTransactionDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Total Overdue Production Projects " + Ex.ToString());
            }

            return aFindTotalOverdueProductionProjectsDataSet;
        }
        public FindTotalOpenStatusProjectsDataSet FindTotalOpenStatusProjects()
        {
            try
            {
                aFindTotalOpenStatusProjectsDataSet = new FindTotalOpenStatusProjectsDataSet();
                aFindTotalOpenStatusProjectsTableAdpater = new FindTotalOpenStatusProjectsDataSetTableAdapters.FindTotalOpenStatusProjectsTableAdapter();
                aFindTotalOpenStatusProjectsTableAdpater.Fill(aFindTotalOpenStatusProjectsDataSet.FindTotalOpenStatusProjects);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Total Open Status Projects " + Ex.ToString());
            }

            return aFindTotalOpenStatusProjectsDataSet;
        }
        public FindTotalOpenProductionProjectsDataSet FindTotalOpenProductionProjects()
        {
            try
            {
                aFindTotalOpenProductionProjectsDataSet = new FindTotalOpenProductionProjectsDataSet();
                aFindTotalOpenProductionProjectsTableAdapter = new FindTotalOpenProductionProjectsDataSetTableAdapters.FindTotalOpenProductionProjectsTableAdapter();
                aFindTotalOpenProductionProjectsTableAdapter.Fill(aFindTotalOpenProductionProjectsDataSet.FindTotalOpenProductionProjects);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Total Open Production Projects " + Ex.ToString());
            }

            return aFindTotalOpenProductionProjectsDataSet;
        }
        public FindOverdueOpenProductionProjectsDataSet FindOverdueProductionProjects(DateTime datECDDate)
        {
            try
            {
                aFindOverdueOpenProductionProjectsDataSet = new FindOverdueOpenProductionProjectsDataSet();
                aFindOverdueOpenProductionProjectsTableAdapter = new FindOverdueOpenProductionProjectsDataSetTableAdapters.FindOverdueOpenProductionProjectsTableAdapter();
                aFindOverdueOpenProductionProjectsTableAdapter.Fill(aFindOverdueOpenProductionProjectsDataSet.FindOverdueOpenProductionProjects, datECDDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Overdue Open Production Projects " + Ex.ToString());
            }

            return aFindOverdueOpenProductionProjectsDataSet;
        }
        public FindProductionProjectTechAssignmentByProjectIDDataSet FindProductionTechAssignmentByProjectID(int intProjectID)
        {
            try
            {
                aFindProductionProjectTechAssignmentByProjectIDDataSet = new FindProductionProjectTechAssignmentByProjectIDDataSet();
                aFindProductionProjectTechAssignmentByProjectIDTableAdapter = new FindProductionProjectTechAssignmentByProjectIDDataSetTableAdapters.FindProductionProjectTechAssignmentByProjectIDTableAdapter();
                aFindProductionProjectTechAssignmentByProjectIDTableAdapter.Fill(aFindProductionProjectTechAssignmentByProjectIDDataSet.FindProductionProjectTechAssignmentByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Tech Assignment By Project ID " + Ex.ToString());
            }

            return aFindProductionProjectTechAssignmentByProjectIDDataSet;
        }
        public FindProductionProjectTechAssignmentByEmployeeDataSet FindProductionProjectTechAssignmentByEmployee(int intEmployeeID, DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindProductionProjectTechAssignmentByEmployeeDataSet = new FindProductionProjectTechAssignmentByEmployeeDataSet();
                aFindProductionProjectTechAssignmentByEmployeeTableAdapter = new FindProductionProjectTechAssignmentByEmployeeDataSetTableAdapters.FindProductionProjectTechAssignmentByEmployeeTableAdapter();
                aFindProductionProjectTechAssignmentByEmployeeTableAdapter.Fill(aFindProductionProjectTechAssignmentByEmployeeDataSet.FindProductionProjectTechAssignmentByEmployee, intEmployeeID, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Tech Assignment By Employee " + Ex.ToString());
            }

            return aFindProductionProjectTechAssignmentByEmployeeDataSet;
        }
        public FindProductionProjectTechAssignmentsOverDateRangeDataSet FindProductionProjectTechAssignmentsOverDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindProductionProjectTechAssignmentsOverDateRangeDataSet = new FindProductionProjectTechAssignmentsOverDateRangeDataSet();
                aFindProductionProjectTechAssignmentsOverDateRangeTableAdapter = new FindProductionProjectTechAssignmentsOverDateRangeDataSetTableAdapters.FindProductionProjectTechnicianAssignmentsOverDateRangeTableAdapter();
                aFindProductionProjectTechAssignmentsOverDateRangeTableAdapter.Fill(aFindProductionProjectTechAssignmentsOverDateRangeDataSet.FindProductionProjectTechnicianAssignmentsOverDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Tech Assignment Over Date Range " + Ex.ToString());
            }

            return aFindProductionProjectTechAssignmentsOverDateRangeDataSet;
        }
        public bool RemoveProductionProjectTechAssignment(int intTransactionID)
        {
            bool blnFatalError = false;

            try
            {
                aRemoveProductionProjectTechAssignmentTableAdapter = new RemoveProductionProjectTechAssignmentEntryTableAdapters.QueriesTableAdapter();
                aRemoveProductionProjectTechAssignmentTableAdapter.RemoveProductionProjectTechAssignment(intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Remove Production Project Tech Assignment " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertProductionProjectTechAssignment(DateTime datDateAssignment, int intProjectID, int intEmployeeID, string strAssignmentNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectTechAssignmentTableAdapter = new InsertProductionProjectTechAssignmentEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectTechAssignmentTableAdapter.InsertProductionProjectTechAssignment(datDateAssignment, intProjectID, intEmployeeID, strAssignmentNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Insert Production Project Tech Assignment " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductionProjectTechAssignedDataSet GetProductionProjectTechAssignedInfo()
        {
            try
            {
                aProductionProjectTechAssignedDataSet = new ProductionProjectTechAssignedDataSet();
                aProductionProjectTechAssignedTableAdapter = new ProductionProjectTechAssignedDataSetTableAdapters.productionprojecttechassignedTableAdapter();
                aProductionProjectTechAssignedTableAdapter.Fill(aProductionProjectTechAssignedDataSet.productionprojecttechassigned);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Get Production Project Tech Assigned Info " + Ex.ToString());
            }

            return aProductionProjectTechAssignedDataSet;
        }
        public void UpdateProductionProjectTechAssignedDB(ProductionProjectTechAssignedDataSet aProductionProjectTechAssignedDataSet)
        {
            try
            {
                aProductionProjectTechAssignedTableAdapter = new ProductionProjectTechAssignedDataSetTableAdapters.productionprojecttechassignedTableAdapter();
                aProductionProjectTechAssignedTableAdapter.Update(aProductionProjectTechAssignedDataSet.productionprojecttechassigned);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Get Production Project Tech Assigned Info " + Ex.ToString());
            }
        }
        public FindProductionProjectPermitsByProjectIDDataSet FindProductionProjectPermitsByProjectID(int intProjectID)
        {
            try
            {
                aFindProductionProjectPermitsByProjectIDDataSet = new FindProductionProjectPermitsByProjectIDDataSet();
                aFindProductionProjectPermitsByProjectIDTableAdapter = new FindProductionProjectPermitsByProjectIDDataSetTableAdapters.FindProductionProjectPermitsByProjectIDTableAdapter();
                aFindProductionProjectPermitsByProjectIDTableAdapter.Fill(aFindProductionProjectPermitsByProjectIDDataSet.FindProductionProjectPermitsByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Permits By Project ID " + Ex.ToString());
            }

            return aFindProductionProjectPermitsByProjectIDDataSet;
        }
        public bool UpdateProductionProjectPermitCost(int intTransactionID, decimal decPermitCost)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectPermitCostTableAdapter = new UpdateProductionProjectPermitCostEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectPermitCostTableAdapter.UpdateProductionProjectPermitCost(intTransactionID, decPermitCost);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Permit Cost " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateProductionProjectPermitReceived(int intTransactionID, DateTime datPermitReceived)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectPermitReceivedTableAdapter = new UpdateProductionProjectPermitPermitReceivedEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectPermitReceivedTableAdapter.UpdateProductionProjectPermitPermitReceived(intTransactionID, datPermitReceived);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Permit Received " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertProductionProjectPermit(int intProjectID, int intEmployeeID, DateTime datPermitRequested, string strPermitType, decimal decPermitCost)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectPermitTableAdapter = new InsertProductionProjectPermitEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectPermitTableAdapter.InsertProductionProjectPermit(intProjectID, intEmployeeID, datPermitRequested, strPermitType, decPermitCost);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Insert Production Project Permit " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductionProjectPermitsDataSet GetProductionProjectPermitsInfo()
        {
            try
            {
                aProductionProjectPermitsDataSet = new ProductionProjectPermitsDataSet();
                aProductionProjectPermitsTableAdapter = new ProductionProjectPermitsDataSetTableAdapters.productionprojectpermitsTableAdapter();
                aProductionProjectPermitsTableAdapter.Fill(aProductionProjectPermitsDataSet.productionprojectpermits);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Get Production Project Permits Info " + Ex.ToString());
            }

            return aProductionProjectPermitsDataSet;
        }
        public void UpdateProductionProjectPermitsDB(ProductionProjectPermitsDataSet aProductionProjectPermitsDataSet)
        {
            try
            {
                aProductionProjectPermitsTableAdapter = new ProductionProjectPermitsDataSetTableAdapters.productionprojectpermitsTableAdapter();
                aProductionProjectPermitsTableAdapter.Update(aProductionProjectPermitsDataSet.productionprojectpermits);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Permits DB " + Ex.ToString());
            }
        }
        public bool UpdateProductionProjectMaterialRequestDateReceived(int intTransactionID, DateTime datDateReceived)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectMaterialRequestDateReceivedTableAdapter = new UpdateProductionProjectMaterialRequestDateReceivedEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectMaterialRequestDateReceivedTableAdapter.UpdateProductionProjectMaterailRequestDateReceived(intTransactionID, datDateReceived);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Materials Request Date Received " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindProductionProjectMaterialRequestByProjectIDDataSet FindProductionProjectMaterialRequestItemsByProjectID(int intProjectID)
        {
            try
            {
                aFindProductionProjectMaterialRequestItemsByProjectIDDataSet = new FindProductionProjectMaterialRequestByProjectIDDataSet();
                aFindProductionProjectMaterialRequestItemsByProjectIDTableAdapter = new FindProductionProjectMaterialRequestByProjectIDDataSetTableAdapters.FindProductionProjectMaterialRequestItemsByProjectIDTableAdapter();
                aFindProductionProjectMaterialRequestItemsByProjectIDTableAdapter.Fill(aFindProductionProjectMaterialRequestItemsByProjectIDDataSet.FindProductionProjectMaterialRequestItemsByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production project Class // Find Production Project Material Request Items By Project ID " + Ex.ToString());
            }

            return aFindProductionProjectMaterialRequestItemsByProjectIDDataSet;
        }
        public FindProductionProjectMaterialRequestItemsByRequestDataSet FindProductionProjectMaterialRequestItemsByRequest(int intMaterialRequestID)
        {
            try
            {
                aFindProductionProjectMaterialRequestItemsByRequestDataSet = new FindProductionProjectMaterialRequestItemsByRequestDataSet();
                aFindProductionProjectMaterialRequestItemsByRequestTableAdapter = new FindProductionProjectMaterialRequestItemsByRequestDataSetTableAdapters.FindProductionProjectMaterailRequestItemsByRequestTableAdapter();
                aFindProductionProjectMaterialRequestItemsByRequestTableAdapter.Fill(aFindProductionProjectMaterialRequestItemsByRequestDataSet.FindProductionProjectMaterailRequestItemsByRequest, intMaterialRequestID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Material Request Items By Request " + Ex.ToString());
            }

            return aFindProductionProjectMaterialRequestItemsByRequestDataSet;
        }
        public bool InsertProductionProjectProjectMaterialRequestItems(int intMaterialRequestID, int intPartID, int intQuantity)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectMaterialRequestItemsTableAdapter = new InsertProductionProjectMaterialRequestItemsEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectMaterialRequestItemsTableAdapter.InsertProductionProjectMaterialRequestItems(intMaterialRequestID, intPartID, intQuantity);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Insert Production Project Material Request Items " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductionProjectMaterialRequestItemsDataSet GetProductionProjectMaterialRequestItemsInfo()
        {
            try
            {
                aProductionProjectMaterialRequestItemsDataSet = new ProductionProjectMaterialRequestItemsDataSet();
                aProductionProjectMaterialRequestItemsTableAdapter = new ProductionProjectMaterialRequestItemsDataSetTableAdapters.productionprojectmaterialrequestitemsTableAdapter();
                aProductionProjectMaterialRequestItemsTableAdapter.Fill(aProductionProjectMaterialRequestItemsDataSet.productionprojectmaterialrequestitems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Get Production Project Material Request Items Info " + Ex.ToString());
            }

            return aProductionProjectMaterialRequestItemsDataSet;
        }
        public void UpdateProductionProjectMaterialRequestItemsDB(ProductionProjectMaterialRequestItemsDataSet aProductionProjectMaterialRequestItemsDataSet)
        {
            try
            {
                aProductionProjectMaterialRequestItemsTableAdapter = new ProductionProjectMaterialRequestItemsDataSetTableAdapters.productionprojectmaterialrequestitemsTableAdapter();
                aProductionProjectMaterialRequestItemsTableAdapter.Update(aProductionProjectMaterialRequestItemsDataSet.productionprojectmaterialrequestitems);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Material Request Items DB " + Ex.ToString());
            }
        }
        public FindProductionProjectMaterialRequestDataSet FindProductionProjectMaterialRequest(int intProjectID)
        {
            try
            {
                aFindProductionProjectMaterialRequestDataSet = new FindProductionProjectMaterialRequestDataSet();
                aFindProductionProjectMaterialRequestTableAdapter = new FindProductionProjectMaterialRequestDataSetTableAdapters.FindProductionProjectMaterialRequestTableAdapter();
                aFindProductionProjectMaterialRequestTableAdapter.Fill(aFindProductionProjectMaterialRequestDataSet.FindProductionProjectMaterialRequest, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Material Request " + Ex.ToString());
            }

            return aFindProductionProjectMaterialRequestDataSet;
        }
        public bool InsertProductionProjectMaterialRequest(int intProjectID, int intEmployeeID, DateTime datRequestDate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectMaterialRequestTableAdapter = new InsertProductionProjectMaterialRequestEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectMaterialRequestTableAdapter.InsertProductionProjectMaterialRequest(intProjectID, intEmployeeID, datRequestDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Insert Production Project Material Request " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductionProjectMaterialRequestDataSet GetProductionProjectMaterialRequestInfo()
        {
            try
            {
                aProductionProjectMaterialRequestDataSet = new ProductionProjectMaterialRequestDataSet();
                aProductionProjectMaterialRequestTableAdapter = new ProductionProjectMaterialRequestDataSetTableAdapters.productionprojectmaterialrequestTableAdapter();
                aProductionProjectMaterialRequestTableAdapter.Fill(aProductionProjectMaterialRequestDataSet.productionprojectmaterialrequest);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Get Production Project Material Request Info " + Ex.ToString());
            }

            return aProductionProjectMaterialRequestDataSet;
        }
        public void UpdateProductionProjectMaterialRequestDB(ProductionProjectMaterialRequestDataSet aProductionProjectMaterialRequestDataSet)
        {
            try
            {
                aProductionProjectMaterialRequestTableAdapter = new ProductionProjectMaterialRequestDataSetTableAdapters.productionprojectmaterialrequestTableAdapter();
                aProductionProjectMaterialRequestTableAdapter.Update(aProductionProjectMaterialRequestDataSet.productionprojectmaterialrequest);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Material Request DB " + Ex.ToString());
            }
        }
        public FindProductionProjectQCByProjectIDDataSet FindProductionProjectQCByProjectID(int intProjectID)
        {
            try
            {
                aFindProductionProjectQCByProjectIDDataSet = new FindProductionProjectQCByProjectIDDataSet();
                aFindProductionProjectQCByProjectIDTableAdapter = new FindProductionProjectQCByProjectIDDataSetTableAdapters.FindProductionProjectQCByProjectIDTableAdapter();
                aFindProductionProjectQCByProjectIDTableAdapter.Fill(aFindProductionProjectQCByProjectIDDataSet.FindProductionProjectQCByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project QC By Project ID " + Ex.ToString());
            }

            return aFindProductionProjectQCByProjectIDDataSet;
        }
        public bool InsertProductionProjectQC(int intProjectID, DateTime datTransactionDate, int intEmployeeID, string strDocumentPath)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectQCTableAdapter = new InsertProductionProjectQCEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectQCTableAdapter.InsertProductionProjectQC(intProjectID, datTransactionDate, intEmployeeID, strDocumentPath);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Insert Production Project QC " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductionProjectQCDataSet GetProductionProjectQCInfo()
        {
            try
            {
                aProductionProjectQCDateSet = new ProductionProjectQCDataSet();
                aProductionProjectQCTableAdapter = new ProductionProjectQCDataSetTableAdapters.productionprojectqcTableAdapter();
                aProductionProjectQCTableAdapter.Fill(aProductionProjectQCDateSet.productionprojectqc);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Get Production Project QC Info " + Ex.ToString());
            }

            return aProductionProjectQCDateSet;
        }
        public FindProductionProjectUpdatesByProjectIDDataSet FindProductionProjectUpdatesByProjectID(int intProjectID)
        {
            try
            {
                aFindProductionProjectUpdatesByProjectIDDataSet = new FindProductionProjectUpdatesByProjectIDDataSet();
                aFindProductionProjectUpdatesByProjectIDTableAdapter = new FindProductionProjectUpdatesByProjectIDDataSetTableAdapters.FindProductionProjectUpdatesByProjectIDTableAdapter();
                aFindProductionProjectUpdatesByProjectIDTableAdapter.Fill(aFindProductionProjectUpdatesByProjectIDDataSet.FindProductionProjectUpdatesByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Updates By Project ID " + Ex.ToString());
            }

            return aFindProductionProjectUpdatesByProjectIDDataSet;
        }
        public ProductionProjectUpdatesDataSet GetProductionProjectUpdatesInfo()
        {
            try
            {
                aProductionProjectUpdatesDataSet = new ProductionProjectUpdatesDataSet();
                aProductionProjectUpdatesTableAdapter = new ProductionProjectUpdatesDataSetTableAdapters.productionprojectupdatesTableAdapter();
                aProductionProjectUpdatesTableAdapter.Fill(aProductionProjectUpdatesDataSet.productionprojectupdates);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Get Production Project Updates Info " + Ex.ToString());
            }

            return aProductionProjectUpdatesDataSet;
        }
        public void UpdateProductionProjectUpdatesDB(ProductionProjectUpdatesDataSet aProductionProjectUpdatesDataSet)
        {
            try
            {
                aProductionProjectUpdatesTableAdapter = new ProductionProjectUpdatesDataSetTableAdapters.productionprojectupdatesTableAdapter();
                aProductionProjectUpdatesTableAdapter.Update(aProductionProjectUpdatesDataSet.productionprojectupdates);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Udpates DB " + Ex.ToString());
            }
        }
        public bool InsertProductionProjectUpdate(int intProjectID, int intEmployeeID, DateTime datTransactionDate, string strProjectUpdate)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectUpdateTableAdapter = new InsertProductionProjectUpdateEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectUpdateTableAdapter.InsertProductionProjectUpdate(intProjectID, intEmployeeID, datTransactionDate, strProjectUpdate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Insert Production Project Update " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindProductionProjectDocumentationByProjectIDDataSet FindProductionProjectDocumentationByProjectID(int intProjectID)
        {
            try
            {
                aFindProductionProjectDocumentationByProjectIDDataSet = new FindProductionProjectDocumentationByProjectIDDataSet();
                aFindProductionProjectDocumentationByProjectIDTableAdapter = new FindProductionProjectDocumentationByProjectIDDataSetTableAdapters.FindProductionProjectDocumentationByProjectIDTableAdapter();
                aFindProductionProjectDocumentationByProjectIDTableAdapter.Fill(aFindProductionProjectDocumentationByProjectIDDataSet.FindProductionProjectDocumentationByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Documentation By Projec ID " + Ex.ToString());
            }

            return aFindProductionProjectDocumentationByProjectIDDataSet;
        }
        public bool InsertProductionProjectDocumentation(int intProjectID, int intEmployeeID, DateTime datTransactionDate, string strDocumentPath)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectDocumentationTableAdapter = new InsertProductionProjectDocumentEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectDocumentationTableAdapter.InsertProductionProjectDocumentation(intProjectID, intEmployeeID, datTransactionDate, strDocumentPath);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Insert Production Project Documentation " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductionProjectDocumentationDataSet GetProductionProjectDocumentationInfo()
        {
            try
            {
                aProductionProjectDocumentationDataSet = new ProductionProjectDocumentationDataSet();
                aProductionProjectDocumentationTableAdapter = new ProductionProjectDocumentationDataSetTableAdapters.productionprojectdocumentationTableAdapter();
                aProductionProjectDocumentationTableAdapter.Fill(aProductionProjectDocumentationDataSet.productionprojectdocumentation);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Get Production Project Documentation Info " + Ex.ToString());
            }

            return aProductionProjectDocumentationDataSet;
        }
        public void UpdateProductionProjectDocumentationDB(ProductionProjectDocumentationDataSet aProductionProjectDocumentationDataSet)
        {
            try
            {
                aProductionProjectDocumentationTableAdapter = new ProductionProjectDocumentationDataSetTableAdapters.productionprojectdocumentationTableAdapter();
                aProductionProjectDocumentationTableAdapter.Update(aProductionProjectDocumentationDataSet.productionprojectdocumentation);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Documentation DB " + Ex.ToString());
            }
        }
        public FindProductionProjectInvoicingTotalsByDateRangeDataSet FindProductionProjectInvoicingTotalsByDateRange(DateTime datStartDate, DateTime datEndDate)
        {
            try
            {
                aFindProductionProjectInvoicingTotalsByDateRangeDataSet = new FindProductionProjectInvoicingTotalsByDateRangeDataSet();
                aFindProductionProjectInvoicingTotalsByDateRangeTableAdapter = new FindProductionProjectInvoicingTotalsByDateRangeDataSetTableAdapters.FindProductionProjectInvoicingTotalsByDateRangeTableAdapter();
                aFindProductionProjectInvoicingTotalsByDateRangeTableAdapter.Fill(aFindProductionProjectInvoicingTotalsByDateRangeDataSet.FindProductionProjectInvoicingTotalsByDateRange, datStartDate, datEndDate);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Invoicing Totals By Date Range " + Ex.ToString());
            }

            return aFindProductionProjectInvoicingTotalsByDateRangeDataSet;
        }
        public FindProductionProjectInvoicingTotalByProjectIDDataSet FindProductionProjectInvoicingTotalByProjectID(int intProjectID)
        {
            try
            {
                aFindProductionProjectInvoicingTotalByProjectIDDataSet = new FindProductionProjectInvoicingTotalByProjectIDDataSet();
                aFindProductionProjectInvoicingTotalByProjectIDTableAdapter = new FindProductionProjectInvoicingTotalByProjectIDDataSetTableAdapters.FindProductionProjectInvoicingTotalByProjectIDTableAdapter();
                aFindProductionProjectInvoicingTotalByProjectIDTableAdapter.Fill(aFindProductionProjectInvoicingTotalByProjectIDDataSet.FindProductionProjectInvoicingTotalByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Invoicing Total By Project ID " + Ex.ToString());
            }

            return aFindProductionProjectInvoicingTotalByProjectIDDataSet;
        }
        public FindProductionProjectInvoicingTransactionsDataSet FindProductionProjectInvoicingTransactions(int intProjectID)
        {
            try
            {
                aFindProductionProjectInvoicingTransactionsDataSet = new FindProductionProjectInvoicingTransactionsDataSet();
                aFindProductionProjectInvoicingTransactionsTableAdapter = new FindProductionProjectInvoicingTransactionsDataSetTableAdapters.FindProductionProjectInvoiceTransactionsTableAdapter();
                aFindProductionProjectInvoicingTransactionsTableAdapter.Fill(aFindProductionProjectInvoicingTransactionsDataSet.FindProductionProjectInvoiceTransactions, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Invoicing Transactions " + Ex.ToString());
            }

            return aFindProductionProjectInvoicingTransactionsDataSet;
        }
        public FindOpenDepartmentProductionProjectsDataSet FindOpenDepartmentProductionProjects(int intDepartmentID)
        {
            try
            {
                aFindOpenDepartmentProductionProjectsDataSet = new FindOpenDepartmentProductionProjectsDataSet();
                aFindOpenDepartmentProductionProjectsTableAdapater = new FindOpenDepartmentProductionProjectsDataSetTableAdapters.FindOpenDepartmentProductionProjectsTableAdapter();
                aFindOpenDepartmentProductionProjectsTableAdapater.Fill(aFindOpenDepartmentProductionProjectsDataSet.FindOpenDepartmentProductionProjects, intDepartmentID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Open Department Production Projects " + Ex.ToString());
            }

            return aFindOpenDepartmentProductionProjectsDataSet;
        }
        public bool UpdateProductionProjectInvoiceStatus(int intTransactionID, string strInvoiceStatus)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectInvoiceStatusTableAdapter = new UpdateProductionProjectInvoiceStatusEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectInvoiceStatusTableAdapter.UpdateProductionProjectInvoiceStatus(intTransactionID, strInvoiceStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Invoice Status " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertProductionProjectInvoice(int intProjectID, string strInvoiceNumber, string strInvoiceType, DateTime datTransactionDate, int intEmployeeID, decimal decInvoiceAmount, string strInvoiceStatus)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectInvoiceTableAdapter = new InsertProductionProjectInvoiceEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectInvoiceTableAdapter.InsertProductionProjectInvoice(intProjectID, strInvoiceNumber, strInvoiceType, datTransactionDate, intEmployeeID, decInvoiceAmount, strInvoiceStatus);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Clas // Insert Production Project Invoice " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductionProjectInvoicingDataSet GetProductionProjectInvoicingInfo()
        {
            try
            {
                aProductionProjectInvoicingDataSet = new ProductionProjectInvoicingDataSet();
                aProductionProjectInvoicingTableAdapter = new ProductionProjectInvoicingDataSetTableAdapters.productionprojectinvoicingTableAdapter();
                aProductionProjectInvoicingTableAdapter.Fill(aProductionProjectInvoicingDataSet.productionprojectinvoicing);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Get Production Project Invoicing Info " + Ex.ToString());
            }

            return aProductionProjectInvoicingDataSet;
        }
        public void UpdateProductionProjectInvoicingDB(ProductionProjectInvoicingDataSet aProductionProjectInvoicingDataSet)
        {
            try
            {
                aProductionProjectInvoicingTableAdapter = new ProductionProjectInvoicingDataSetTableAdapters.productionprojectinvoicingTableAdapter();
                aProductionProjectInvoicingTableAdapter.Update(aProductionProjectInvoicingDataSet.productionprojectinvoicing);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Invoicing DB " + Ex.ToString());
            }
        }
        public FindProductionProjectCableTotalByProjectIDDataSet FindProductionProjectCableTotalsByProjectID(int intProjectID)
        {
            try
            {
                aFindProductionProjectCableTotalsByProjectIDDataSet = new FindProductionProjectCableTotalByProjectIDDataSet();
                aFindProductionProjectCableTotalsByProjectIDTableAdapter = new FindProductionProjectCableTotalByProjectIDDataSetTableAdapters.FindProductionProjectCableTotalsByProjectIDTableAdapter();
                aFindProductionProjectCableTotalsByProjectIDTableAdapter.Fill(aFindProductionProjectCableTotalsByProjectIDDataSet.FindProductionProjectCableTotalsByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Cable Totals By Project ID " + Ex.ToString());
            }

            return aFindProductionProjectCableTotalsByProjectIDDataSet;
        }
        public FindProductionProjectCableByProjectIDDataSet FindProductionProjectCableByProjectID(int intProjectID)
        {
            try
            {
                aFindProductionProjectCableByProjectIDDataSet = new FindProductionProjectCableByProjectIDDataSet();
                aFindProductionProjectCableByProjectIDTableAdapter = new FindProductionProjectCableByProjectIDDataSetTableAdapters.FindProductionProjectCableByProjectIDTableAdapter();
                aFindProductionProjectCableByProjectIDTableAdapter.Fill(aFindProductionProjectCableByProjectIDDataSet.FindProductionProjectCableByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Cable By Project ID " + Ex.ToString());
            }

            return aFindProductionProjectCableByProjectIDDataSet;
        }
        public bool UpdateProductionProjectCablePartID(int intTransactionID, int intPartID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectCablePartIDTableAdapter = new UpdateProductionProjectCablePartIDEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectCablePartIDTableAdapter.UpdateProductionProjectCablePartID(intTransactionID, intPartID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Cable Part ID " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool RemoveProductionProjectCable(int intTransactionID)
        {
            bool blnFatalError = false;

            try
            {
                aRemoveProductionProjectCableTableAdapter = new RemoveProductionProjectCableEntryTableAdapters.QueriesTableAdapter();
                aRemoveProductionProjectCableTableAdapter.RemoveProductionProjectCable(intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Remove Production Project Cable " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateProductionProjectCableType(int intTransactionID, string strCableType)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectCableTypeTableAdapter = new UpdateProductionProjectCableTypeEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectCableTypeTableAdapter.UpdateProductionProjectCableType(intTransactionID, strCableType);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Cable Type " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateProductionProjectCableFootage(int intTransactionID, int intFootage)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectCableFootageTableAdapter = new UpdateProductionProjectCableFootageEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectCableFootageTableAdapter.UpdateProductionProjectCableFootage(intTransactionID, intFootage);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Cable Footage " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertProductionProjectCable(int intProjectID, string strPlacmentType, string strCableType, DateTime datTransactionDate, int intEmployeeID, int intFootage, int intPartID)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectCableTableAdapter = new InsertProductionProjectCableEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectCableTableAdapter.InsertProductionProjectCable(intProjectID, strPlacmentType, strCableType, datTransactionDate, intEmployeeID, intFootage, intPartID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Insert Production Project Cable " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductionProjectCableDataSet GetProductionProjectCableInfo()
        {
            try
            {
                aProductionProjectCableDateSet = new ProductionProjectCableDataSet();
                aProductionProjectCableTableAdapter = new ProductionProjectCableDataSetTableAdapters.productionprojectcableTableAdapter();
                aProductionProjectCableTableAdapter.Fill(aProductionProjectCableDateSet.productionprojectcable);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Get Production Project Cable Info " + Ex.ToString());
            }

            return aProductionProjectCableDateSet;
        }
        public void UpdateProductionProjectCableDB(ProductionProjectCableDataSet aProductionProjectCableDateSet)
        {
            try
            {
                aProductionProjectCableTableAdapter = new ProductionProjectCableDataSetTableAdapters.productionprojectcableTableAdapter();
                aProductionProjectCableTableAdapter.Update(aProductionProjectCableDateSet.productionprojectcable);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Cable DB " + Ex.ToString());
            }
        }
        public FindProductionProjectInfoPOAmountDataSet FindProductionProjectInfoPOAmount(int intProjectID)
        {
            try
            {
                aFindProductionProjectInfoPOAmountDataSet = new FindProductionProjectInfoPOAmountDataSet();
                aFindProductionProjectInfoPOAmountTableAdapter = new FindProductionProjectInfoPOAmountDataSetTableAdapters.FindProductionProjectInfoPOAmountTableAdapter();
                aFindProductionProjectInfoPOAmountTableAdapter.Fill(aFindProductionProjectInfoPOAmountDataSet.FindProductionProjectInfoPOAmount, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Info PO Amount " + Ex.ToString());
            }

            return aFindProductionProjectInfoPOAmountDataSet;
        }
        public FindProductionProjectInfoNeedingQCDataSet FindProductionProjectInfoNeedingQC()
        {
            try
            {
                aFindProductionProjectInfoNeedingQCDataSet = new FindProductionProjectInfoNeedingQCDataSet();
                aFindProductionProjectInfoNeedingQCTableAdapter = new FindProductionProjectInfoNeedingQCDataSetTableAdapters.FindProductionProjectInfoNeedingQCTableAdapter();
                aFindProductionProjectInfoNeedingQCTableAdapter.Fill(aFindProductionProjectInfoNeedingQCDataSet.FindProductionProjectInfoNeedingQC);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Info Needing QC " + Ex.ToString());
            }

            return aFindProductionProjectInfoNeedingQCDataSet;
        }
        public FindProductionProjectInfoNeedingSplicingDataSet FindProductionProjectInfoNeedingSplicingin()
        {
            try
            {
                aFindProductionProjectInfoNeedingSplicingDataSet = new FindProductionProjectInfoNeedingSplicingDataSet();
                aFindProductionProjectInfoNeedingSplicingTableAdapter = new FindProductionProjectInfoNeedingSplicingDataSetTableAdapters.FindProductionProjectsNeedingSplicingTableAdapter();
                aFindProductionProjectInfoNeedingSplicingTableAdapter.Fill(aFindProductionProjectInfoNeedingSplicingDataSet.FindProductionProjectsNeedingSplicing);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Info Needing Splicing " + Ex.ToString());
            }

            return aFindProductionProjectInfoNeedingSplicingDataSet;
        }
        public FindProductionProjectInfoDataSet FindProductionProjectInfo(int intProjectID)
        {
            try
            {
                aFindProductionProjectInfoDataSet = new FindProductionProjectInfoDataSet();
                aFindProductionProjectInfoTableAdapter = new FindProductionProjectInfoDataSetTableAdapters.FindProductionProjectInfoTableAdapter();
                aFindProductionProjectInfoTableAdapter.Fill(aFindProductionProjectInfoDataSet.FindProductionProjectInfo, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project Info " + Ex.ToString());
            }

            return aFindProductionProjectInfoDataSet;
        }
        public bool RemoveProductionProjectInfo(int intTransactionID)
        {
            bool blnFatalError = false;

            try
            {
                aRemoveProductionProjectInfoTableAdapter = new RemoveProductionProjectInfoEntryTableAdapters.QueriesTableAdapter();
                aRemoveProductionProjectInfoTableAdapter.RemoveProductionProjectInfo(intTransactionID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Remove Production Project Info " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateProductionProjectInfoQCPerformed(int intTransactionID, bool blnQCPerformed)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectInfoQCPerformedTableAdapter = new UpdateProductionProjectInfoQCPerformedEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectInfoQCPerformedTableAdapter.UpdateProductionProjectInfoQCPerformed(intTransactionID, blnQCPerformed);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Info QC Performed " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateProductionProjectInfoHardRestoration(int intTransactionID, bool blnHardResetoration)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectInfoHardRestorationTableAdapter = new UpdateProductionProjectInfoHardRestorationEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectInfoHardRestorationTableAdapter.UpdateProductionProjectInfoHardRestoration(intTransactionID, blnHardResetoration);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Info Hard Restoration " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateProductionProjectInfoSplicingComplete(int intTransactionID, bool blnSplicingComplete)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectInfoSplicingCompleteTableAdapter = new UpdateProductionProjectInfoSplicingCompleteEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectInfoSplicingCompleteTableAdapter.UpdateProductionProjectInfoSplicingComplete(intTransactionID, blnSplicingComplete);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Info Splicing Complete " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool UpdateProductionProjectInfoPOAmount(int intTransactionID, Decimal decPOAmount)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectInfoPOAmountTableAdapter = new UpdateProductionProjectInfoPOAmountEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectInfoPOAmountTableAdapter.UpdateProductionProjectInfoPOAmount(intTransactionID, decPOAmount);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Info PO Amount " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertProductionProjectInfo(int intProjectID, int intJobType, string strPointOfContact, string strPONumber, decimal decPOAmount)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectInfoTableAdapter = new InsertProductionProjectInfoEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectInfoTableAdapter.InsertProductionProjectInfo(intProjectID, intJobType, strPointOfContact, strPONumber, decPOAmount);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Insert Production Project Info " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductionProjectInfoDataSet GetProductionProjectInfoInfo()
        {
            try
            {
                aProductionProjectInfoDataSet = new ProductionProjectInfoDataSet();
                aProductionProjectInfoTableAdapter = new ProductionProjectInfoDataSetTableAdapters.productionprojectinfoTableAdapter();
                aProductionProjectInfoTableAdapter.Fill(aProductionProjectInfoDataSet.productionprojectinfo);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Get Production Project Info Info " + Ex.ToString());
            }

            return aProductionProjectInfoDataSet;
        }
        public void UpdateProductionPronjectInfoDB(ProductionProjectInfoDataSet aProductionProjectInfoDataSet)
        {
            try
            {
                aProductionProjectInfoTableAdapter = new ProductionProjectInfoDataSetTableAdapters.productionprojectinfoTableAdapter();
                aProductionProjectInfoTableAdapter.Update(aProductionProjectInfoDataSet.productionprojectinfo);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Info DB " + Ex.ToString());
            }
        }
        public bool UpdateProductionProject(int intTransactionID, int intDepartmentID, string strAddress, string strCity, string strState, int intManagerID, int intOfficeID, DateTime datECDDate, string strProjectNotes)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectTableAdapter = new UpdateProductionProjectTableAdapterTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectTableAdapter.UpdateProductionProject(intTransactionID, intDepartmentID, strAddress, strCity, strState, intManagerID, intOfficeID, datECDDate, strProjectNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public FindProductionProjectByProjectIDDataSet FindProductionProjectByProjectID(int intProjectID)
        {
            try
            {
                aFindProductionProjectByProjectIDDataSet = new FindProductionProjectByProjectIDDataSet();
                aFindProductionProjectByProjectIDTableAdapter = new FindProductionProjectByProjectIDDataSetTableAdapters.FindProductionProjectByProjectIDTableAdapter();
                aFindProductionProjectByProjectIDTableAdapter.Fill(aFindProductionProjectByProjectIDDataSet.FindProductionProjectByProjectID, intProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Project By Project ID " + Ex.ToString());
            }

            return aFindProductionProjectByProjectIDDataSet;
        }
        public FindProductionProjectsByCurrentStatusIDDataSet FindProductionProjectsByCurrentStatusID(int intCurrentStatusID)
        {
            try
            {
                aFindProductionProjectsByCurrentStatusIDDataSet = new FindProductionProjectsByCurrentStatusIDDataSet();
                aFindProductionProjectsByCurrentStatusIDTableAdapter = new FindProductionProjectsByCurrentStatusIDDataSetTableAdapters.FindProductionProjectsByCurrentStatusIDTableAdapter();
                aFindProductionProjectsByCurrentStatusIDTableAdapter.Fill(aFindProductionProjectsByCurrentStatusIDDataSet.FindProductionProjectsByCurrentStatusID, intCurrentStatusID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Projects By Current ID " + Ex.ToString());
            }

            return aFindProductionProjectsByCurrentStatusIDDataSet;
        }
        public FindOpenProductionProjectsDataSet FindOpenProductionProjects()
        {
            try
            {
                aFindOpenProductionProjectsDataSet = new FindOpenProductionProjectsDataSet();
                aFindOpenProductionProjectsTableAdapter = new FindOpenProductionProjectsDataSetTableAdapters.FindOpenProductionProjectsTableAdapter();
                aFindOpenProductionProjectsTableAdapter.Fill(aFindOpenProductionProjectsDataSet.FindOpenProductionProjects);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Open Production Projects " + Ex.ToString());
            }

            return aFindOpenProductionProjectsDataSet;
        }
        public FindProdutionProjectsByAssignedProjectIDDataSet FindProductionProjectsByAssignedProjectID(string strAssignedProjectID)
        {
            try
            {
                aFindProductionProjectsByAssignedProjectIDDataSet = new FindProdutionProjectsByAssignedProjectIDDataSet();
                aFindProductionProjectsByAssignedProjectsIDTableAdapter = new FindProdutionProjectsByAssignedProjectIDDataSetTableAdapters.FindProductionProjectByAssignedProjectIDTableAdapter();
                aFindProductionProjectsByAssignedProjectsIDTableAdapter.Fill(aFindProductionProjectsByAssignedProjectIDDataSet.FindProductionProjectByAssignedProjectID, strAssignedProjectID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Projects By Assigned Project ID " + Ex.ToString());
            }

            return aFindProductionProjectsByAssignedProjectIDDataSet;
        }
        public bool UpdateProductionProjectStatus(int intTransactionID, int intCurrentStatusID)
        {
            bool blnFatalError = false;

            try
            {
                aUpdateProductionProjectStatusTableAdapter = new UpdateProductionProjectStatusEntryTableAdapters.QueriesTableAdapter();
                aUpdateProductionProjectStatusTableAdapter.UpdateProductionProjectStatus(intTransactionID, intCurrentStatusID);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Status " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertProdutionProject(int intProjectID, int intBusinessLineID, string strBusinessAddress, string strCity, string strBusinessState, int intProjectManagerID, int intAssignedOfficeID, DateTime datReceiveDate,  DateTime datECDDate, int intCurrentStatusID, string strProjectNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectTableAdapter = new InsertProductionProjectEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectTableAdapter.InsertProductionProject(intProjectID, intBusinessLineID, strBusinessAddress, strCity, strBusinessState, intProjectManagerID, intAssignedOfficeID, datReceiveDate, datECDDate, intCurrentStatusID, strProjectNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Insert Production Project " + Ex.ToString());

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public ProductionProjectsDataSet GetProductionProjectsInfo()
        {
            try
            {
                aProductionProjectsDataSet = new ProductionProjectsDataSet();
                aProductionProjectsTableAdapter = new ProductionProjectsDataSetTableAdapters.productionprojectsTableAdapter();
                aProductionProjectsTableAdapter.Fill(aProductionProjectsDataSet.productionprojects);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Projects Class // Get Productions Projects Info " + Ex.ToString());
            }

            return aProductionProjectsDataSet;
        }
        public void UpdateProductionProjectsDB(ProductionProjectsDataSet aProductionProjectsDataSet)
        {
            try
            {
                aProductionProjectsTableAdapter = new ProductionProjectsDataSetTableAdapters.productionprojectsTableAdapter();
                aProductionProjectsTableAdapter.Update(aProductionProjectsDataSet.productionprojects);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Projects Class // Update Productions Projects DB " + Ex.ToString());
            }
        }
    }
}
