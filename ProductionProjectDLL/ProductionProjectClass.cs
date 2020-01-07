/* Title:       Production Project Classs
 * Date:        1-4-20
 * Author:      Terry Holmes
 * 
 * Description: This is used for production projects */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewEventLogDLL;

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
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Projects By Current ID " + Ex.Message);
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
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Open Production Projects " + Ex.Message);
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
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Find Production Projects By Assigned Project ID " + Ex.Message);
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
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Update Production Project Status " + Ex.Message);

                blnFatalError = true;
            }

            return blnFatalError;
        }
        public bool InsertProdutionProject(int intProjectID, int intBusinessLineID, string strBusinessAddress, string strCity, string strBusinessState, int intProjectManagerID, int intAssignedOfficeID,  DateTime datECDDate, int intCurrentStatusID, string strProjectNotes)
        {
            bool blnFatalError = false;

            try
            {
                aInsertProductionProjectTableAdapter = new InsertProductionProjectEntryTableAdapters.QueriesTableAdapter();
                aInsertProductionProjectTableAdapter.InsertProductionProject(intProjectID, intBusinessLineID, strBusinessAddress, strCity, strBusinessState, intProjectManagerID, intAssignedOfficeID, DateTime.Now, datECDDate, intCurrentStatusID, strProjectNotes);
            }
            catch (Exception Ex)
            {
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Project Class // Insert Production Project " + Ex.Message);

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
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Projects Class // Get Productions Projects Info " + Ex.Message);
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
                TheEventLogClass.InsertEventLogEntry(DateTime.Now, "Production Projects Class // Update Productions Projects DB " + Ex.Message);
            }
        }
    }
}
