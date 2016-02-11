using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestChasseurDeTetes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestValidationDateDebutInfDateFin()
        {
            DateTime DD1 = new DateTime(2012 / 12 / 21);
            DateTime? DF1 = new DateTime(2013 / 03 / 13);

            Assert.AreEqual(true, ChasseurDeTetes.Vues.FormExperiences.ValidationDate(DD1, DF1));
        }
        [TestMethod]
        public void TestValidationDateDebutSupDateFin()
        {
            DateTime DD2 = new DateTime(2022 / 12 / 21);
            DateTime? DF1 = new DateTime(2013 / 03 / 13);
            Assert.AreEqual(true, ChasseurDeTetes.Vues.FormExperiences.ValidationDate(DD2, DF1));
        }
        [TestMethod]
        public void TestValidationDateDebutSansDateFin()
        {
            DateTime DD1 = new DateTime(2012 / 12 / 21);
            DateTime? DF2 = null;
            Assert.AreEqual(true, ChasseurDeTetes.Vues.FormExperiences.ValidationDate(DD1, DF2));
        }

        [TestMethod]
        public void TestValidation1()
        {
            ChasseurDeTetes.Metier.Experience exp = new ChasseurDeTetes.Metier.Experience();
            DateTime DD = DateTime.Today.AddYears(-200);
            exp.DateDebut = DD;
            Assert.AreEqual(1, ChasseurDeTetes.Vues.FormExperiences.Validation(exp));

        }
        [TestMethod]
        public void TestValidation2()
        {
            ChasseurDeTetes.Metier.Experience exp = new ChasseurDeTetes.Metier.Experience();
            DateTime DD2 = DateTime.Today.AddYears(2);
            DateTime? DF1 = DateTime.Today;
            exp.DateDebut = DD2;
            exp.DateFin = DF1;
            Assert.AreEqual(2, ChasseurDeTetes.Vues.FormExperiences.Validation(exp));
        }
        [TestMethod]
        public void TestValidation3()
        {
            ChasseurDeTetes.Metier.Experience exp = new ChasseurDeTetes.Metier.Experience();
            exp.DateDebut = DateTime.Today;
            exp.Lentreprise = new ChasseurDeTetes.Metier.Entreprise(0);
            exp.Commentaire = null;
            Assert.AreEqual(3, ChasseurDeTetes.Vues.FormExperiences.Validation(exp));
        }
        [TestMethod]
        public void TestValidation0()
        {
            ChasseurDeTetes.Metier.Experience exp = new ChasseurDeTetes.Metier.Experience();
            exp.DateDebut = DateTime.Today;
            exp.DateFin = DateTime.Today.AddYears(2);
            exp.Lentreprise = new ChasseurDeTetes.Metier.Entreprise(1);
            Assert.AreEqual(0, ChasseurDeTetes.Vues.FormExperiences.Validation(exp));
        }
    }
}
