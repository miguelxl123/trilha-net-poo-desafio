using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "123456789", modelo: "Modelo3310", imei: "11234454262521", memoria: 32);
        nokia.Ligar();
        nokia.InstalarAplicativo("Whatsapp");


        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Iphone:");
        Smartphone iphone = new Iphone(numero: "1234562789", modelo: "Modelo6s", imei: "1512526", memoria: 64);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Whatsapp");


