# Triângulo de Sierpinski

O Triângulo de Sierpinski é um fractal e um exemplo clássico de geometria recursiva, nomeado após o matemático polonês Wacław Sierpiński. Ele é gerado utilizando um processo iterativo simples, onde um triângulo é subdividido recursivamente, removendo os triângulos menores de forma a criar uma forma complexa e auto-similar.

## Método do Jogo do Caos

O método utilizado neste projeto é o "Jogo do Caos", um algoritmo probabilístico que gera padrões de fractais, como o Triângulo de Sierpinski. Ele é baseado em um processo simples, onde pontos aleatórios são selecionados dentro de um triângulo e se aproximam sucessivamente do ponto médio de um dos vértices do triângulo, criando o padrão desejado.

## Características

- **Geração Recursiva:** O triângulo é gerado de maneira recursiva, com cada ponto sendo criado a partir da média dos vértices escolhidos aleatoriamente.
- **Fractal Auto-similar:** A estrutura do Triângulo de Sierpinski se repete em escalas menores dentro de si mesma, o que o torna um exemplo perfeito de um fractal.
- **Visualização Gráfica:** A implementação usa a biblioteca SDL para exibir o padrão gerado na tela de forma eficiente e visualmente agradável.

## Este Projeto

Este projeto foi criado a partir de um vídeo no TikTok: [Sierpinski's Triangle - @reason4math - TikTok](https://www.tiktok.com/@reason4math/video/7439902423692447018). A implementação utiliza SDL para exibir a simulação na tela, com as bindings do ppy.SDL2-CS.
