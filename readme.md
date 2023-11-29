Programa de consulta de cep
Ao baixar o repositório criar o seguinte banco de dados no xampp> phpmyadmin com o nome de cep_consulta com a seguinte tabela
CREATE TABLE `usuarioscep` (
  `id_usuario` int(255) NOT NULL,
  `nome` varchar(255) NOT NULL,
  `cpf` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `senha` varchar(255) NOT NULL
)
Outra forma é executar o arquivo cep_consulta.sql no programa MySQLworkbench.

Sobre o projeto
O programa de consulta de cep é um projeto prático feito na linguagem C# com .net framework
A ideia consistia em apresentar um layout com formulário e banco de dados integrado.

Com meu aprendizado criei as seguintes telas:

Login onde é possível interagir com os textbox, respeitando as regras do banco de dados para efetuar login.
Caso os dados não coincidam apresenta a mensagem de erro via método Try,Catch e Finally. Em caso positivo, o usuário é direcionado a próxima tela.

![image](https://github.com/Alissonvsantos2023/ProjetosCsharp/assets/134982920/a27574e5-def8-4558-95ce-8ae7d2d888e2)

Outrora, se não houver cadastro existe a opção no link abaixo que direciona para a página onde o usuário insere os dados, assim que salvar, exibe a mensagem de “Dados salvos com sucesso” e o usuário é redirecionado ao login.
![image](https://github.com/Alissonvsantos2023/ProjetosCsharp/assets/134982920/809622f5-a176-45a0-8054-c4751b2d35cd)


 
Após ter feito as validações o programa exibe a tela de consultas, onde você digita o número do cep no canto superior esquerdo e para consultar clica no botão “Consultar cep” localizado no canto superior direito.

Com a integração da API ViaCep os dados são listados abaixo respectivamente.

![image](https://github.com/Alissonvsantos2023/ProjetosCsharp/assets/134982920/d1899f97-8035-458b-9979-54a99b6e675f)


 
Ao final, temos o botão limpar do lado esquerdo que apaga as informações e permite uma nova consulta. Por fim, ao lado direito temos o botão sair que fecha a aplicação.


