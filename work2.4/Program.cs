var a = Console.ReadLine();

int number_a;

bool isNum = int.TryParse(a, out number_a);




while(isNum == false || number_a == 0){

    Console.WriteLine("Введите число не равное нулю");

    a = Console.ReadLine();

    isNum = int.TryParse(a, out number_a);

}




if (number_a>0) {

    for(int i = 1; i<=number_a; i++){

        if(i%2==0) Console.Write(i + " ");

    }

} else {

    for(int i = 1; i>=number_a; i--){




        if(i == 0){

            continue;

        }else{

            if(i%2==0){

            Console.Write(i + " ");

        }

        }

    }

}