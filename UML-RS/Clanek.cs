namespace UMLRS{
    class Clanek : iClanek {
        private int idClanek;
        private String nadpisClanku;
        private String prefixClanku;
        private String textClanku;
        //Vyvoření vazby typu "agregace" mezi objekty Clanek a Autor, pokračování v konstruktoru
        private Autor autorClanku;

        //Předání reference na vytvořený objekt pomocí parametru autorClanku
        public Clanek(int idClanek, Autor autorClanku, String nadpisClanku, String prefixClanku, String textClanku){
            this.autorClanku = autorClanku;
            this.idClanek = idClanek;
            this.nadpisClanku = nadpisClanku;
            this.prefixClanku = prefixClanku;
            this.textClanku = textClanku;
        }

        public void Vytvorit(){
                Console.WriteLine("Članek vytvořen...");
        }
        public void Smazat(){
            Console.WriteLine("Članek smazán...");
        }
        public void Editovat(){
            Console.WriteLine("Članek upraven...");
        }
        
        public override String ToString(){
            return ("ID: " + this.idClanek + "\nAutor: \n" + this.autorClanku + "\nNázev knihy: " + this.nadpisClanku + "\nPrefix: " + this.prefixClanku + "\nText Článku: " + this.textClanku);
        } 
    }
}