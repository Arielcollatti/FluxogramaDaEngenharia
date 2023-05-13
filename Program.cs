Console.WriteLine(" ----FluxogramaDaEngenharia----/n ");

Console.Write("Esta se Movendo (S/N)? ");
string Movendo = Console.ReadLine()!;

if (Movendo == "S")
{
    Console.Write("Deveria (S/N)  ");
    string Deveria = Console.ReadLine()!;

    if (Deveria == "S") {
        Console.WriteLine("Ótimo");
    }else if (Deveria == "N") {
        Console.WriteLine("Passe silver tape ");
    } else {
        Console.WriteLine("Opção invalida !");
    }
}
else if (Movendo == "N"){
     Console.Write("Deveria (S/N)  ");
    string Deveria = Console.ReadLine()!;
    
    if (Deveria == "S"){
        Console.WriteLine("Passe WD-40. ");
    }else if (Deveria == "N"){
        Console.WriteLine("Ótimo");
    }else{
        Console.WriteLine("Opção invalida ");
    }}else{
        Console.WriteLine("Opção invalida ");
}






