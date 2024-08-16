using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalutiWebApi.test
{
    public class SalutiControllerTest
    {
        SalutiController salutiController;

        public SalutiControllerTest() {
            salutiController = new SalutiController();
        }
        /*
        [fact]
        public void testGetSaluti() 
        {
            string retval = salutiController.getSaluti();
            string testval = "Sono la api in C#";

            //Assert.Equal(testval, retval);
        }

        [Fact]
        public void testGetSalutiParametrizzato()
        {
            string retval = salutiController.getSaluti("Prova");
            string testval = "\"Saluti, Prova sono la api in C#\"";

            //Assert.Equal(testval, retval);
        }
        */
    }
}