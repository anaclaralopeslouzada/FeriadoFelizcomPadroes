# Sistema Integrado de Monitoramento Urbano (SmartCity)

Este projeto foi desenvolvido como um exercício integrador para consolidar o conhecimento sobre todos os padrões de projeto estudados até o momento com o Prof. Fábio Fagundes Silveira.

## O Enunciado do Exercício
"Desenvolver um sistema de controle para uma **Cidade Inteligente** que gerencie sensores de diversos tipos. O sistema deve ser capaz de:
1.  **Notificar** prefeituras interessadas sobre mudanças nos dados (Observer).
2.  **Validar** se os dados recebidos são reais antes de processá-los (Proxy).
3.  **Simplificar** a operação de monitoramento para o usuário final (Facade).
4.  **Integrar** sensores antigos que enviam dados em formatos obsoletos (Adapter).
5.  **Adicionar filtros** de processamento ou calibragem nos dados de forma dinâmica (Decorator)."

---

## Padrões de Projeto Aplicados:

- **Observer**: Utilizado para que as Prefeituras (Observadores) recebam alertas automáticos das PCDs (Sujeitos) apenas das regiões que elas escolheram monitorar.
- **Proxy**: Atua como uma camada de segurança. O `PCDProxy` intercepta o dado e verifica se a temperatura é plausível (ex: entre -50°C e 100°C) antes de enviar para o sistema real.
- **Facade**: A `CentralFacade` oferece uma interface "limpa" para o usuário, escondendo toda a complexidade de instanciar filtros, adaptadores e proxies.
- **Decorator**: Permite que a gente adicione uma "camada" de calibragem ao sensor sem mexer no código original dele, somando valores de ajuste ao resultado final.
- **Adapter**: Criado para converter os dados de sensores antigos (que retornam strings complexas) para o novo padrão numérico do sistema.

## Estrutura do Projeto:
- `Interfaces.cs`: Contratos base para os padrões Observer e Decorator.
- `Sensores.cs`: Implementação do sensor base e dos Decorators de filtragem.
- `Adapters.cs`: Converte sistemas legados para a interface atual.
- `Monitoramento.cs`: Contém o Subject (PCDReal) e o Proxy de proteção.
- `CentralFacade.cs`: A porta de entrada simplificada do sistema.
- `Program.cs`: Demonstração de todos os padrões trabalhando juntos em um fluxo real.

## Como rodar o código:
O repositório contém o arquivo de projeto (`.csproj`). Para executar e testar as notificações no terminal:

```bash
dotnet run
