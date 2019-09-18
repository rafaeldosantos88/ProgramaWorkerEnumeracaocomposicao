using System.Collections.Generic;
using Course.Entities.Enums;


namespace Course.Entities
{
    class Worker
    {
        public string Name { get; set; }//Nome do trabalhador
        public WorkerLevel Level { get; set; }//Nível do Trabalhador
        public double BaseSalary { get; set; }//Base Salarial do Trabralhador
        public Department Department { get; set; }//Composição do departamento
        public List<HourContract>Contracts { get; set; }=new List<HourContract>();//Composição Contrato em lista

        public Worker()//Construtor padrão
        {

        }

        //Não foi colocado como construtor Contract,não vou incluir associação para muitos,no caso contratos,não é usual passar uma lista para o construtor de objetos,essa lista vai começar vazia,depois vou adicionado os objetos comforme minha necessidade.Via de regra quando tiver uma associação para muitos você não vai incluir ela no construtor
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);  //Vai ser adicionado um contrato para esse trabalhador,vai ter que adicionar esse contrato recebido aqui dentro da lista de contrato do trabalhador HoursContract
        }
        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);   //Remover Contrato
        }
        public double Income(int year,int month) // foi inserido Income aonde signigica aonde mostra quanto um trabalhador ganhou determinado ano e determinado mês
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
                return sum;
            }
        }
        

        
    }
}
