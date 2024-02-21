namespace UMLRS{
    class Clanek : iClanek {
        
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