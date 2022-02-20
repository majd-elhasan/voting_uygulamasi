using System;
namespace Voting{
     
    class MainClass{
        static List<Users> User_list = new List<Users>();
        static void Main(string[] args){
            

            Console.WriteLine("bir kategori seçiniz.");
            for(int i = 0 ; i< Kategoriler.kategoriler.Count ; i++){
                Console.WriteLine("{0}. {1}", i+1, Kategoriler.kategoriler[i]);
            }
            short input = 0;
            try_input();
            void try_input(){
               bool Try = Int16.TryParse(Console.ReadLine(),out input);
                if (input == 0) try_input();
            }
            Giris_Yap();
            switch (input)
            {
                case 1:
                    film_kategorisi(Kategoriler.film_Voting);
                break;

                case 2:
                    ders_kategorisi(Kategoriler.ders_Voting);
                break;

                case 3:
                    dil_kategorisi(Kategoriler.dil_Voting);
                break;
            }
        }
        static void film_kategorisi(Dictionary<string,int> dict){
            Console.WriteLine("Aşağıdaki filmlerden birine oy veriniz.");
            kategori_sec(dict);
        }
        static void ders_kategorisi(Dictionary<string,int> dict){
            Console.WriteLine("Aşağıdaki filmlerden birine oy veriniz.");
            kategori_sec(dict);
        }
        static void dil_kategorisi(Dictionary<string,int> dict){
            Console.WriteLine("Aşağıdaki filmlerden birine oy veriniz.");
            kategori_sec(dict);
        }
        
        static void kategori_sec(Dictionary<string,int> dict){
            
            int counter = 1;
            foreach (var item in dict)
            {
                Console.WriteLine("{0}. {1}", counter, item.Key);
                counter++;
            }
            counter = 0;
            short input = 0;
            try_input();
            void try_input(){
            input = try_short_input();
            if (input >= dict.Count){Console.WriteLine("Geçersiz bir oylama yaptınız ."); try_input();}
            }
            foreach(var item in dict){
                
                if (input == counter+1){dict[item.Key] += 1; break;}
                counter ++;
            }
            sonuclari_goster(dict);
            Console.WriteLine("__________________");
            Console.WriteLine("yeniden başlatmak için 'r' tuşlayınız.");
            if(Console.ReadLine() == "r"){Main(new string[0]);}
            else Environment.Exit(0);
        }
        static void sonuclari_goster(Dictionary<string,int> dict){
            Console.WriteLine("".PadRight(20) +  "puan".PadRight(10) + "yüzde"  );
            int oylama_sayisi = 0;
            foreach (var item in dict)
            {
                oylama_sayisi += item.Value;
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key.PadRight(20) +  item.Value.ToString().PadRight(10) + (double)(item.Value * 100/oylama_sayisi) + "%" );
            }
        }
        static string try_input()
        {
            string input = Console.ReadLine();
            if (input == ""){Console.WriteLine("boş bırakmayınız");  try_input();}
            return input;
        }
        static short try_short_input()
        {
            bool Try = Int16.TryParse(Console.ReadLine(),out short input);
            if (input == 0) try_short_input();
            return input;
        }
        static void Kayit_Ol(string name){
            int time = DateTime.Now.Hour;
            string s_time = time >5 && time <10 ? "Günaydın ":time >= 10 && time <18?"iyi günler ": "iyi geceler ";
            Console.WriteLine("{0}{1} !",s_time,name);
            Console.WriteLine("adınızı giriniz.");
            string username = try_input();
            Console.WriteLine("şifre giriniz.");
            string password = try_input();

            User_list.Add(new Users(username,password));
            //Main(new string[0]);
        }
        static void Giris_Yap(){
            Console.Write("Lütfen Kullanıcı adınızı giriniz : ");
            string input = Console.ReadLine();
            int counter = 0;
            foreach (var item in User_list)
            {
                if (item.Username != input)
                counter ++;
            }
            if (counter == User_list.Count){
                Console.WriteLine("Sistemde kayıtlı değilsiniz !");
                Console.WriteLine("kaydolmak ister misiniz ?  (Evet için  'e', Hayır için  'h') tuşlayınız.");
                if (Console.ReadLine() == "e")
                    Kayit_Ol(input);
                else Environment.Exit(0);
            }

               
        }
    }
}