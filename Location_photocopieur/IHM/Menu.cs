using Location_photocopieur.Utils;

namespace Location_photocopieur.IHM
{
    internal class Menu
    {
        public Menu()
        {
            string[] listeChoixEntites= { "Client", "Photocopieur", "Technicien" };
            Console.WriteLine("=== Location ===\n");
            Console.WriteLine("[1] Client");
            Console.WriteLine("[2] Photocopieur");
            Console.WriteLine("[3] Technicien");
            Console.WriteLine("[0] Quitter\n");

            int[] choixPossible = { 0, 1, 2, 3 };
            int choixEntite = Valideur.InputInt("Faites votre choix : ", "\tVeuillez faire un choix valide.", true, choixPossible);

            if (choixEntite == 0) // Quitter
            {
                return;
            }

            Console.Clear();
            Console.WriteLine($"=== {listeChoixEntites[choixEntite-1]} ===\n");
            Console.WriteLine($"[1] Créer un {listeChoixEntites[choixEntite - 1]}");
            Console.WriteLine($"[2] Lire un {listeChoixEntites[choixEntite - 1]}");
            Console.WriteLine($"[3] Modifier un {listeChoixEntites[choixEntite - 1]}");
            Console.WriteLine($"[4] Supprimer un {listeChoixEntites[choixEntite - 1]}");
            Console.WriteLine("[0] Quitter\n");

            int[] choixPossibleCRUD = { 0, 1, 2, 3, 4 };
            int choixAction = Valideur.InputInt("Faites votre choix : ","\tVeuillez faire un choix valide.", true, choixPossibleCRUD);

            if (choixEntite == 0) // Quitter
            {
                return;
            }


        }
    }
}
