// See https://aka.ms/new-console-template for more information
using Cust0mL1st.Collection;

MyList<string> list = new MyList<string>();
list.add("Azerbaijan");
list.add("Turkish");
list.add("Usa");
list.add("Rusia");
list.add("Ukraina");
list.add("Poland");
list.add("Germany");
list.add("England");
list.add("China");
list.add("Japan");
list.add("Korea");
list.add("Pakistan");
MyList<int>list2 = new MyList<int>();
Console.WriteLine(list2.Find(i=>i==100));
list2.add(1);
list2.add(2);
list2.add(3);
Console.WriteLine(list.Contains("Azerbaijan"));