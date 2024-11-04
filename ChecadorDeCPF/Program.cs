namespace ChecadorDeCPF {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("-=-=-=-=-=-=-");
            Console.WriteLine("VALIDAR CPF");
            Console.WriteLine("-=-=-=-=-=-=-");

            bool IsNumeric(string input) => input.All(char.IsDigit);

            while (true) {
                Console.WriteLine(" ");
                Console.Write("Formatos aceitos\n00011122233\n000.111.222-33\n \nDigite seu CPF: ");
                string cpf = Console.ReadLine();

                if ((cpf.Trim()).Length == 11) {
                    string cpf_formatado = (cpf.Trim());
                    if (IsNumeric(cpf_formatado)) {
                        if (((cpf_formatado[0] - '0') * 10 +
                            (cpf_formatado[1] - '0') * 9 +
                            (cpf_formatado[2] - '0') * 8 +
                            (cpf_formatado[3] - '0') * 7 +
                            (cpf_formatado[4] - '0') * 6 +
                            (cpf_formatado[5] - '0') * 5 +
                            (cpf_formatado[6] - '0') * 4 +
                            (cpf_formatado[7] - '0') * 3 +
                            (cpf_formatado[8] - '0') * 2) * 10 % 11 == (cpf_formatado[9] - '0') &&
                            ((cpf_formatado[0] - '0') * 11 +
                            (cpf_formatado[1] - '0') * 10 +
                            (cpf_formatado[2] - '0') * 9 +
                            (cpf_formatado[3] - '0') * 8 +
                            (cpf_formatado[4] - '0') * 7 +
                            (cpf_formatado[5] - '0') * 6 +
                            (cpf_formatado[6] - '0') * 5 +
                            (cpf_formatado[7] - '0') * 4 +
                            (cpf_formatado[8] - '0') * 3 +
                            (cpf_formatado[9] - '0') * 2) * 10 % 11 == (cpf_formatado[10] - '0')) {
                            string cpf_final = cpf_formatado.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                            Console.WriteLine($"O CPF {cpf_final} é válido!");
                            break;
                        }
                        else {
                            Console.WriteLine("CPF inválido! Tente novamente.");
                            continue;
                        }
                    }
                }
                else if ((cpf.Trim()).Length == 14 &&
                        cpf[3] == '.' &&
                        cpf[7] == '.' &&
                        cpf[11] == '-') {
                    string cpf_formatado2 = ((cpf.Trim()).Replace(".", "")).Replace("-", "");
                    if (IsNumeric(cpf_formatado2)) {
                        if (((cpf_formatado2[0] - '0') * 10 +
                            (cpf_formatado2[1] - '0') * 9 +
                            (cpf_formatado2[2] - '0') * 8 +
                            (cpf_formatado2[3] - '0') * 7 +
                            (cpf_formatado2[4] - '0') * 6 +
                            (cpf_formatado2[5] - '0') * 5 +
                            (cpf_formatado2[6] - '0') * 4 +
                            (cpf_formatado2[7] - '0') * 3 +
                            (cpf_formatado2[8] - '0') * 2) * 10 % 11 == (cpf_formatado2[9] - '0') &&
                            ((cpf_formatado2[0] - '0') * 11 +
                            (cpf_formatado2[1] - '0') * 10 +
                            (cpf_formatado2[2] - '0') * 9 +
                            (cpf_formatado2[3] - '0') * 8 +
                            (cpf_formatado2[4] - '0') * 7 +
                            (cpf_formatado2[5] - '0') * 6 +
                            (cpf_formatado2[6] - '0') * 5 +
                            (cpf_formatado2[7] - '0') * 4 +
                            (cpf_formatado2[8] - '0') * 3 +
                            (cpf_formatado2[9] - '0') * 2) * 10 % 11 == (cpf_formatado2[10] - '0')) {
                            Console.WriteLine($"O CPF {cpf.Trim()} é válido!");
                            break;
                        }
                    }
                    else {
                        Console.WriteLine("CPF inválido! Tente novamente.");
                        continue;
                    }
                }
                else {
                    Console.WriteLine("CPF inválido! Tente novamente.");
                    continue;
                }
            }
        }
    }
}
