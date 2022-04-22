using NUnit.Framework;

using Lab.MVVM.Entities;
using Lab.MVVM.Interfaces;

namespace Lab.MVVM.Tests.Patterns.Command
{
    public class Tests
    {
        AlfaGeneration phone;

        [SetUp]
        public void Setup()
        {
            phone = new AlfaGeneration("RedMi_Note_7", "Anno=2014")
            {
                LifeStatus = 100,
                Cover = "Nera",
            };

            phone.Install(new AlfaGenerationApplication("Rubrica", "Sistema", 64));
            phone.Install(new AlfaGenerationApplication("Calendario", "Sistema", 4434));
            phone.Install(new AlfaGenerationApplication("Impostazioni", "Sistema", 455544));
        
            phone.SetProperty(ID)
        }

        [Test]
        public void Test1()
        {

        }
    }
}