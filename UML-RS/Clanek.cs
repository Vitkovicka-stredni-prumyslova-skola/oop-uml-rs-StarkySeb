namespace UMLRS{
    class Clanek : iClanek {
        private int idClanek;
        private String nadpisClanku;
        private String prefixClanku;
        private String textClanku;
        private Autor autorClanku;

        public Clanek(Autor autorClanku){
            this.autorClanku = autorClanku;
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
        
        public String toString(){
            return "null";
        } 
    }
}