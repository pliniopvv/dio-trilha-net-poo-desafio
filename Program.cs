using DesafioPOO.Models;

Iphone i = new Iphone("34999999999", "6","46143543433435",4);
i.Ligar();
i.InstalarAplicativo("WhatsApp");
i.ReceberLigacao();

Nokia n = new Nokia("34555555555", "Tijolon", "4354534354354343", 6);
n.Ligar();
n.ReceberLigacao();
n.InstalarAplicativo("WhatsApp Black");