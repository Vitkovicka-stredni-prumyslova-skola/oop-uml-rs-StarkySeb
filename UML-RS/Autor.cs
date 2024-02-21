namespace UMLRS{
    class Autor {

        int idAutora;
        String nick;
        String prijmeni;
        String jmeno;
        String email;

        public int IdAutora{
            get{return this.idAutora;}
        }
        public String Nick{
            get{return this.nick;}
        }
        public String Prijmeni{
            get{return this.prijmeni;}
            set{this.prijmeni = value;}
        }
        public String Jmeno{
            get{return this.jmeno;}
            set{this.jmeno = value;}
        }
        public String Email{
            get{return this.email;}
            set{this.email = value;}
        }

        public void Vytvorit(){
            Console.WriteLine("Autor vytvořen...");
        }

        public void Smazat(){
            Console.WriteLine("Autor smazán...");
        }
        public void Editovat(){
            Console.WriteLine("Autor upraven...");
        }

        override public  String ToString(){
            return ("Jmeno: " + this.jmeno + "\nPříjmení: " + this.prijmeni);
        }

        
    }
}