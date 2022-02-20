namespace Voting{
    public static class Kategoriler{
        public static List<string> kategoriler = new List<string>(){"Filmler","Dersler","Diller"};

        public static Dictionary<string,int> film_Voting = new Dictionary<string,int>(){{"Ayla",0},{"kelebek etkisi",0},{"The room",0},{"Venom",0},{"Himura Kenshin",0}};
        public static Dictionary<string,int> ders_Voting = new Dictionary<string,int>()
        {{"Matematik",0},{"Edebiyat",0},{"Tarih",0},{"Coğrafya",0},{"Yabancı dil",0},{"Biyoloji",0},{"Fizik",0},{"Kimya",0}};
        public static Dictionary<string,int> dil_Voting = new Dictionary<string,int>()
        {{"Almanca",0},{"Arapça",0},{"Çince",0},{"Farsça",0},{"Hintçe",0},{"İbranice",0},{"İngilizce",0},{"İspanyolca",0},{"İtalyanca",0},{"Korece",0},{"Rusça",0},{"Türkçe",0}};

    }
}