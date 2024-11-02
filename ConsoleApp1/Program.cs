
interface IAve
{
    void Volar();
    void Cantar();
    void PonerHuevos();
}


interface IAveNadadora
{
    void Nadar();
}

interface IAveCazadora
{
    void Cazar();
}


class Pato : IAve, IAveNadadora
{
    public void Volar() { /* implementación específica para Pato */ }
    public void Cantar() { /* implementación específica para Pato */ }
    public void PonerHuevos() { /* implementación específica para Pato */ }
    public void Nadar() { /* implementación específica para Pato */ }
}

// Clase para un águila, que puede cazar y volar
class Aguila : IAve, IAveCazadora
{
    public void Volar() { /* implementación específica para Aguila */ }
    public void Cantar() { /* implementación específica para Aguila */ }
    public void PonerHuevos() { /* implementación específica para Aguila */ }
    public void Cazar() { /* implementación específica para Aguila */ }
}
