🏦 Sistema Bancário Sprint
Uma aplicação de console robusta desenvolvida em .NET 10 para simular operações bancárias essenciais. Este projeto foi criado para demonstrar conceitos de modelagem de dados, lógica de negócios e interação via CLI (Command Line Interface).

📝 Descrição
O Sistema Bancário Sprint permite a gestão simplificada de contas e transações financeiras. O foco principal é a integridade das operações e a clareza do fluxo de usuário, utilizando as tecnologias mais recentes do ecossistema .NET. e 
vinculação com banc de dados mysql

🎯 Objetivos do Projeto
Implementar modelagem de contas bancárias.

Gerenciar fluxo de depósitos, saques e transferências.

Validar regras de negócio (ex: saldo insuficiente).

Demonstrar o uso de coleções em memória.

Apos tudo isso salvar no mysql

🚀 Como Funciona
A aplicação opera através de um menu interativo no console. O fluxo básico segue a lógica:

Entrada: O usuário escolhe uma opção e fornece os dados.

Processamento: O sistema valida os dados e atualiza o estado em memória.

Saída: Feedback imediato sobre o sucesso ou erro da operação.

Caso testar no swagger voce precisa fazer login ou cadastro pegar o token digitar Bearer e colar seu token

Funcionalidades Principais:
👤 Criar Conta: Registro de titular e geração de ID.

💰 Depósito: Incremento de saldo em contas existentes.

💸 Saque: Retirada de valores com verificação de disponibilidade.

🔄 Transferência: Movimentação entre contas com validação dupla.

📊 Consulta: Visualização de saldo e extrato detalhado.

🛠️ Requisitos Técnicos
Para rodar este projeto, você precisará de:

SDK: .NET 10.0 ou superior.

SO: Windows, macOS ou Linux.

Hardware: Mínimo de 2GB RAM e 1 CPU.

⚙️ Instalação e Execução
Siga os passos abaixo para testar o sistema localmente:

Clonar o repositório:

Bash
git clone https://github.com/cauaamorim/Sistema-Bancario-Sprint.git
cd Sistema-Bancario-Sprint
Restaurar dependências:

Bash
dotnet restore
Compilar o projeto:

Bash
dotnet build
Executar:

Bash
dotnet run --project ./Sistema-bancario-Sprint/Sistema-bancario-Sprint.csproj
📂 Estrutura do Projeto (Sugestão)
Plaintext
├── 📁 Models       # Classes de entidade (Conta, Cliente)
├── 📁 Services     # Lógica de negócio e validações
├── 📁 Utils        # Formatadores e auxiliares
└── 📄 Program.cs   # Ponto de entrada e Menu Principal
⚠️ Boas Práticas e Limitações
[!IMPORTANT]

Persistência: Os dados são mantidos apenas em memória. Ao fechar o programa, as informações serão perdidas.

Concorrência: Este sistema não foi projetado para múltiplos acessos simultâneos (Thread-safe).

Validações: O sistema impede valores negativos, mas certifique-se de inserir dados no formato correto.

🏗️ Evoluções Futuras
[ ] Implementar persistência em banco de dados (SQLite/SQL Server).

[ ] Criar testes unitários com xUnit.

[ ] Adicionar autenticação com senha para cada conta.

[ ] Evoluir para uma Web API com ASP.NET Core.

🤝 Contribuição
Contribuições são muito bem-vindas!

Faça um Fork do projeto.

Crie uma Branch para sua feature (git checkout -b feature/NovaFeature).

Dê um Commit nas alterações (git commit -m 'Adicionando nova funcionalidade').

Dê um Push na Branch (git push origin feature/NovaFeature).

Abra um Pull Request.
