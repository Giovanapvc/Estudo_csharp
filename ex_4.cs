using System; 

//beecrowd 1094: exemplo
//Maria has just started as graduate student in a medical school and she's needing your help to organize a laboratory experiment which she is responsible about. She wants to know, at the end of the year, how many animals were used in this laboratory and the percentage of each type of animal is used at all.
//This laboratory uses in particular three types of animals: frogs, rats and rabbits. To obtain this information, it knows exactly the number of experiments that were performed, the type and quantity of each animal is used in each experiment.



class ex {
    static void Main(string[] args) { 

        int n, x, coelhos=0, ratos=0, sapos=0, total=0;
        float perc_c, perc_r, perc_s;
        char y;

        n=int.Parse(Console.ReadLine());  //leitura do numero de dados

        int[] vet = new int[n];

        for (int i = 0; i < n; i++)
        {
            //separando os dados por espaço, e depois em dois arrays com parse de int e string
            string[] array = Console.ReadLine().Split(' ');  

            x=int.Parse(array[0]);   //quantidade do animal
            y=char.Parse(array[1]);  //tipo de animal contado

            if(y == 'C')
            {
                coelhos+=x;
                total+=x;

            }else if(y == 'R')
            {
                ratos+=x;
                total+=x;

            }else if(y == 'S')
            {
                sapos+=x;
                total+=x;
            }
        }


        Console.WriteLine("Total: {0} cobaias", total);
        Console.WriteLine("Total de coelhos: {0}",coelhos);
        Console.WriteLine("Total de ratos: {0}",ratos);
        Console.WriteLine("Total de sapos: {0}",sapos);

        perc_c=(float)coelhos/total*100;
        perc_r=(float)ratos/total*100;
        perc_s=(float)sapos/total*100;

        Console.WriteLine("Percentual de coelhos: {0} %", perc_c.ToString("N2"));
        Console.WriteLine("Percentual de ratos: {0} %", perc_r.ToString("N2"));
        Console.WriteLine("Percentual de sapos: {0} %", perc_s.ToString("N2"));  //n2 para mostrar numeração com virgula em 2 casas

    }

}