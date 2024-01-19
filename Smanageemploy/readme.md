A la racine du projet backend faire la commande :

docker-compose up --force-recreate --build -d

une fois le docker monter il faut build le projet avec la commande en dessous (même emplacement)

dotnet ef dbcontext scaffold "Host=localhost;Port=5432;Database=postgres;User Id=postgres;Password=example;" Npgsql.EntityFrameworkCore.PostgreSQL -o Entities --context-dir Infrastructures/Database/ -c ManageEmployeeDbContext -d -f

Pour lire le projet l'adresse par défaut et le localhost 5000 (j'ai eu quelques probleme pour m'y connecter par moment je devazis rentrer l'adresse en entiere sinon il n'y avait pas de redirection : localhost:5000/swagger/index.html