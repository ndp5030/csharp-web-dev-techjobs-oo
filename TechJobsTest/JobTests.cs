using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTest
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();
            Assert.IsFalse(job1.Id == job2.Id);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Employer employer1 = new Employer("ACME");
            Location location1 = new Location("Desert");
            PositionType jobType1 = new PositionType("Quality Control");
            CoreCompetency competency1 = new CoreCompetency("Persistence");
            Job job3 = new Job("Product Tester", employer1, location1, jobType1, competency1);
            Assert.IsTrue(job3.Name == "Product Tester");
            Assert.IsTrue(job3.EmployerName.Value == "ACME");
            Assert.IsTrue(job3.EmployerLocation.Value == "Desert");
            Assert.IsTrue(job3.JobType.Value == "Quality Control");
            Assert.IsTrue(job3.JobCoreCompetency.Value == "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            //Which is better? The first one is not DRY but the second creates another new instance for each class and we're supposed to be using the same

            //TechJobsOO.Employer employer1 = new TechJobsOO.Employer("ACME");
            //TechJobsOO.Location location1 = new TechJobsOO.Location("Desert");
            //TechJobsOO.PositionType jobType1 = new TechJobsOO.PositionType("Quality Control");
            //TechJobsOO.CoreCompetency competency1 = new TechJobsOO.CoreCompetency("Persistence");
            //TechJobsOO.Job job3 = new TechJobsOO.Job("Product Tester", employer1, location1, jobType1, competency1);
            //TechJobsOO.Job job4 = new TechJobsOO.Job("Product Tester", employer1, location1, jobType1, competency1);

            TechJobsOO.Job job3 = new TechJobsOO.Job("Product Tester", new TechJobsOO.Employer("ACME"), new TechJobsOO.Location("Desert"), new TechJobsOO.PositionType("Quality Control"), new TechJobsOO.CoreCompetency("Persistence"));
            TechJobsOO.Job job4 = new TechJobsOO.Job("Product Tester", new TechJobsOO.Employer("ACME"), new TechJobsOO.Location("Desert"), new TechJobsOO.PositionType("Quality Control"), new TechJobsOO.CoreCompetency("Persistence"));
            
            // Just thinking about how to make the object dry
            TechJobsOO.Job job5 = new TechJobsOO.Job("Product Tester", job4.EmployerName, job4.EmployerLocation, job4.JobType, job4.JobCoreCompetency);

            Assert.IsFalse(job3.Equals(job4));

            // Assert.AreNotEqual(job3, job4);
        }

        [TestMethod]
        public void TestJobsToStringMethod()
        {
            TechJobsOO.Employer employer1 = new TechJobsOO.Employer("ACME");
            TechJobsOO.Location location1 = new TechJobsOO.Location("Desert");
            TechJobsOO.PositionType jobType1 = new TechJobsOO.PositionType("Quality Control");
            TechJobsOO.CoreCompetency competency1 = new TechJobsOO.CoreCompetency("Persistence");
            TechJobsOO.Job job3 = new TechJobsOO.Job("Product Tester", employer1, location1, jobType1, competency1);

            Assert.IsTrue(job3.ToString() == $"\nID: {job3.Id} \nName: {job3.Name} \nEmployer: {job3.EmployerName.Value} \nLocation: {job3.EmployerLocation.Value} \nPosition Type: {job3.JobType.Value} \nCore Competency: {job3.JobCoreCompetency.Value}\n");
        }

        [TestMethod]
        public void TestEmptyStringMethod()
        {
            TechJobsOO.Job job3 = new TechJobsOO.Job("Product Tester", new TechJobsOO.Employer("ACME"), new TechJobsOO.Location(""), new TechJobsOO.PositionType("Quality Control"), new TechJobsOO.CoreCompetency("Persistence"));
            Assert.IsTrue(job3.ToString() == $"\nID: {job3.Id} \nName: {job3.Name} \nEmployer: {job3.EmployerName.Value} \nLocation: Data not available \nPosition Type: {job3.JobType.Value} \nCore Competency: {job3.JobCoreCompetency.Value}\n");
        }
    }
}
