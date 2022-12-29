using RecordKeeperBizObjects;
using System.Data;
using CPUFramework;
using Dapper;
using System.Data.SqlClient;

namespace RecordKeeperTest2
{
    public class Tests
    {
        int totalprez = 0;
        int maxpreznum = 0;
        int maxprezid = 0;
        int prezwithexecorderid = 0;
        string connstring = "";

        [SetUp]
        public void Setup()
        {
            connstring = DataUtility.SetConnectionString("mgellis2022.database.windows.net,1433", "RecordKeeperDB", "cpuadmin", "CPU123!@#");
            DataTable dt = SQLUtility.GetDataTable(connstring, "select total = count(*) from president");
            totalprez = (int)dt.Rows[0]["total"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 p.presidentId, p.Num from president p order by p.num desc");
            maxpreznum = (int)dt.Rows[0]["Num"];
            maxprezid = (int)dt.Rows[0]["PresidentId"];

            dt = SQLUtility.GetDataTable(connstring, "select top 1 p.presidentId, p.Num from president p join ExecutiveOrder e on e.PresidentId = p.PresidentId order by p.num desc");
            prezwithexecorderid = (int)dt.Rows[0]["PresidentId"];
        }


        /*
        7
        46
        3
         */
        //[Test]
        //public void TestPresidentList()
        //{
        //    DataTable dt = DataService.GetPresidentList();
        //    TestContext.WriteLine("Num presidents " + dt.Rows.Count.ToString());
        //    Assert.IsTrue(dt.Rows.Count == totalprez);

        //}

        ////[Test]
        ////public void TestPartyList() {
        ////    DataTable dt = DataService.GetPartyList();
        ////    TestContext.WriteLine("Num Parties " + dt.Rows.Count.ToString());
        ////    Assert.IsTrue(dt.Rows.Count == 7);

        ////}


        ////[Test]
        ////public void TestUSGovSummary()
        ////{
        ////    DataTable dt = DataService.GetUSGovRecordSummary();
        ////    TestContext.WriteLine("Num records fro summary " + dt.Rows.Count.ToString());
        ////    Assert.IsTrue(dt.Rows.Count == 3);

        ////}

        ////1058	Millard	Fillmore

        //[Test]
        //public void TestLoadPresidentDapper()
        //{
        //    using (SqlConnection conn = new SqlConnection(connstring))
        //    {
        //        bizPresident prez = conn.QueryFirstOrDefault<bizPresident>("select top 1 * from president order by num");
        //        TestContext.WriteLine(prez.FullDescription());
        //    }
        //}

        //[Test]
        //public void TestLoadPresident()
        //{
        //    bizPresident prez = bizPresident.Get(maxprezid);
            
        //    TestContext.WriteLine("Prez FullDescription = " + prez.FullDescription());
        //    Assert.IsTrue(prez.Num == maxpreznum);
        //}

        //[Test]
        //public void TestNewPresident()
        //{
        //    bizPresident prez = new bizPresident();
        //    prez.FirstName = "Yonason";
        //    prez.LastName = "Adams";
        //    prez.DateBorn = DateTime.Now.AddMonths(-450);
        //    prez.DateDied = DateTime.Now.AddMonths(24);
        //    prez.TermStart = DateTime.Now.Year;
        //    prez.Save();
        //    TestContext.WriteLine("New president num = " + prez.Num.ToString() + ". Should be " + (maxpreznum + 1));
        //    Assert.IsTrue(prez.Num == maxpreznum + 1);

        //}

        //[Test]
        //public void TestChangePresidentNumber()
        //{
        //    bizPresident prez = bizPresident.Get(maxprezid);
        //    prez.Num = prez.Num + 1;
        //    Assert.Throws<CPUException>(() => prez.Save(), "You cannot change a president's number");

        //    TestContext.WriteLine(prez.FullDescription());
        //}

        //[Test]
        //public void TestDeletePresidentWithExecutiveOrder()
        //{
        //    bizPresident prez = bizPresident.Get(prezwithexecorderid);
            
        //    Assert.Throws<CPUException>(() => prez.Delete());
        //}
    }
}