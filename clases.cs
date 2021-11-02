public class Libro
{
    public string Nombre { get; set;}
    public string Autor { get; set;}
    public int Copias { get; set;}
    public int Prestadas { get; set;}

        // public libro(string nombre, string autor, int copias, int prestadas){
        //     Nombre = nombre;
        //     Autor = autor;
        //     Copias = copias;
        //     Prestadas = prestadas;
        // }

        public void prestar(int Cprestadas){
            if(Copias > 0){
                Copias = Copias - Cprestadas;
            } else {
                System.Console.WriteLine();
            }
        }

        public void devolver(int DCprestadas){
            if(Copias < 50){
                Copias = Copias + DCprestadas;
            } else {
                System.Console.WriteLine();
            }
        }

        public int mostrar(){
            return Copias;
        }
}
