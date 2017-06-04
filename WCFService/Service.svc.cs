using Mirabeau.MsSql.Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFService.Common;

namespace WCFService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    public class Service1 : IService
    {

        public List<Customer> GetCustomer(string customerID)
        {
            List<Customer> listCustomer = new List<Customer>();

            string CMD = "GetCustomer";

            var parameters = new List<SqlParameter>
            {
                customerID.CreateSqlParameter("customerID")
            };

            DataSet dataSet = DatabaseHelper.ExecuteDataSet(GlobalVar.connectionString, CommandType.StoredProcedure, CMD, parameters);
            DataTable dataTable = dataSet.Tables[0];

            foreach (DataRow dataRow in dataTable.Rows)
            {
                Customer customer = new Customer();

                customer.customerID = dataRow["CustomerID"].ToString().Trim();
                customer.customerName = dataRow["CustomerName"].ToString().Trim();
                customer.customerAddress = dataRow["CustomerAddress"].ToString().Trim();

                listCustomer.Add(customer);
            }

            return listCustomer;
        }

        public string GetCustomerByJSon(string customerID)
        {
            string CMD = "GetCustomer";

            var parameters = new List<SqlParameter>
            {
                customerID.CreateSqlParameter("customerID")
            };

            DataSet dataSet = DatabaseHelper.ExecuteDataSet(GlobalVar.connectionString, CommandType.StoredProcedure, CMD, parameters);

            return JsonConvert.SerializeObject(dataSet);
        }

        public void SetCustomer(string customerName, string customerAddress)
        {
            string CMD = "SetCustomer";

            var parameters = new List<SqlParameter>
            { };

            DatabaseHelper.ExecuteNonQuery(GlobalVar.connectionString, CommandType.StoredProcedure, CMD, parameters);
        }
    }
}
