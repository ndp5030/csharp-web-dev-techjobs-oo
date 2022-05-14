using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            TechJobsOO.Job job1 = new TechJobsOO.Job();
            TechJobsOO.Job job2 = new TechJobsOO.Job();
            Assert.IsFalse(job1.Id.Equals(job2.Id));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            TechJobsOO.Employer employer1 = new TechJobsOO.Employer("ACME");
            TechJobsOO.Location location1 = new TechJobsOO.Location("Desert");
            TechJobsOO.PositionType jobType1 = new TechJobsOO.PositionType("Quality Control");
            TechJobsOO.CoreCompetency competency1 = new TechJobsOO.CoreCompetency("Persistence");
            TechJobsOO.Job job3 = new TechJobsOO.Job("Product Tester", employer1, location1, jobType1, competency1);
            Assert.IsNotNull(job3.Name);
            Assert.IsNotNull(job3.EmployerName);
            Assert.IsNotNull(job3.EmployerLocation);
            Assert.IsNotNull(job3.JobType);
            Assert.IsNotNull(job3.JobCoreCompetency);
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            TechJobsOO.Employer employer1 = new TechJobsOO.Employer("ACME");
            TechJobsOO.Location location1 = new TechJobsOO.Location("Desert");
            TechJobsOO.PositionType jobType1 = new TechJobsOO.PositionType("Quality Control");
            TechJobsOO.CoreCompetency competency1 = new TechJobsOO.CoreCompetency("Persistence");
            TechJobsOO.Job job3 = new TechJobsOO.Job("Product Tester", employer1, location1, jobType1, competency1);

            TechJobsOO.Job job4 = new TechJobsOO.Job("Product Tester", employer1, location1, jobType1, competency1);

            Assert.IsFalse(job3.Equals(job4));

            // Assert.AreNotEqual(job3, job4);
        }
    }
}
