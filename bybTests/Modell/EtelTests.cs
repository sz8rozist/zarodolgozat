using Microsoft.VisualStudio.TestTools.UnitTesting;
using byb.Modell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace byb.Modell.Tests
{
    [TestClass()]
    public class EtelTests
    {
        //Rossz teszteset
        [TestMethod()]
        public void validateTestEnevIsEmpty()
        {
            try
            {
                Etel e = new Etel("",23,23,23,23,"23gr");
                if (e.validate())
                {
                    Assert.Fail("Üres név esetén nem dob kivételt!");
                }
            }
            catch (ValidateEtelNevIsEmpty vene)
            {
                if (vene.Message != "Megkell adnod az étel nevét!")
                    Assert.Fail("Üres név esetén hibát dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Üres név esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }
        //Rossz teszteset
        [TestMethod()]
        public void validateTestEfeherjeIsNegativ()
        {
            try
            {
                Etel e = new Etel("Csirkemell", -2, 23, 23, 23, "23gr");
                if (e.validate())
                {
                    Assert.Fail("Negatív fehérje érték esetén nem dob kivételt!");
                }
            }
            catch (ValidateFeherjeIsNegative vene)
            {
                if (vene.Message != "Negatív értéket nem adhatsz meg!")
                    Assert.Fail("Negatív fehérje érték esetén hibát dob, de a hiba szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Negatív fehérje érték esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }
        //Jó teszteset
        [TestMethod()]
        public void validateTestEnevFirstLetterUpperCase()
        {
            try
            {
                Etel etel = new Etel("Csirkemell",2,3,4,5,"3g");
                if (etel.validate())
                {
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Az étel első betűje nagybetű mégis hibát dob");
            }
        }
        //Jó teszteset
        [TestMethod()]
        public void validateTestMennyisegFirstCharacterIsNumber()
        {
            try
            {
                Etel e = new Etel("Csirkemell", 23, 23, 23, 23, "43gr");
                if (e.validate())
                {
                   
                }
            }
            catch (Exception e)
            {
                Assert.Fail("Ha az első karakter betű de mégis hibát dob!");
            }
        }

        //Jó teszteset
        [TestMethod()]
        public void validateTestMennyisegVanBenneBetu()
        {
            try
            {
                Etel e = new Etel("Csirkemell", 23, 23, 23, 23, "43gr");
                if (e.validate())
                {

                }
            }
            catch (Exception e)
            {
                Assert.Fail("Van benne betű de mégis hibát dob!");
            }
        }

        //Jó teszteset
        [TestMethod()]
        public void validateTestMindenMezoKitoltve()
        {
            try
            {
                Etel e = new Etel("Csirkemell", 23, 23, 23, 23, "43gr");
                if (e.validate())
                {

                }
            }
            catch (Exception e)
            {
                Assert.Fail("Minden ki van töltve de mégis hibát dob!");
            }
        }
    }
}