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

            Job job3 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Job job4 = new Job("Product Tester", job3.EmployerName, job3.EmployerLocation, job3.JobType, job3.JobCoreCompetency);

            Assert.IsFalse(job3.Equals(job4));

            // Assert.AreNotEqual(job3, job4);
        }

        [TestMethod]
        public void TestJobsToStringMethod()
        {
            Job job3 = new Job("Product Tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality Control"), new CoreCompetency("Persistence"));

            Assert.IsTrue(job3.ToString() == $"\nID: {job3.Id} \nName: {job3.Name} \nEmployer: {job3.EmployerName.Value} \nLocation: {job3.EmployerLocation.Value} \nPosition Type: {job3.JobType.Value} \nCore Competency: {job3.JobCoreCompetency.Value}\n");
        }

        [TestMethod]
        public void TestEmptyStringMethod()
        {
            Job job3 = new Job("Product Tester", new Employer("ACME"), new Location(""), new PositionType("Quality Control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(job3.ToString() == $"\nID: {job3.Id} \nName: {job3.Name} \nEmployer: {job3.EmployerName.Value} \nLocation: Data not available \nPosition Type: {job3.JobType.Value} \nCore Competency: {job3.JobCoreCompetency.Value}\n");
        }
    }
}
