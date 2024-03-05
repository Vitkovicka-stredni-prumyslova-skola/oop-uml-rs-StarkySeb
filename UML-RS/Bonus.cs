using System.Reflection;

namespace UMLRS{

    interface iBonus {

        /// <summary>
        /// Metoda vytvoří instanci článku v RS
        /// </summary>
        void PridejBody(int body);
        void UberBody(int body);
        void ResetBody(int body);
    
        String ToString();    
        
    }
class Bonus: iBonus{
        private int body;
        
        public Bonus(int body){
            this.body = body;
        }
        public void PridejBody(int body){
            this.body += body;
        }
        public void UberBody(int body){
            this.body -= body;
        }
        public void ResetBody(int body){
            this.body = 0;
        }
        
        override public string ToString(){
            return $"Počet bodů: {this.body}";
        }    
        
}




}