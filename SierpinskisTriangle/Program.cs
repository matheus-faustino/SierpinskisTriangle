using SDL2;

namespace SierpinskisTriangle
{
    internal class Program
    {
        const int WINDOW_WIDTH = 1000;
        const int WINDOW_HEIGHT = 1000;

        static void Main(string[] args)
        {
            // Define as vértices do triângulo
            int[,] vertices = new int[3, 2] { { 500, 200 }, { 900, 800 }, { 100, 800 } };

            // Cria a janela de exibição
            SDL.SDL_Init(SDL.SDL_INIT_VIDEO);

            IntPtr window = SDL.SDL_CreateWindow("Sierpinski's Triangle - Matheus Faustino",
                SDL.SDL_WINDOWPOS_CENTERED, SDL.SDL_WINDOWPOS_CENTERED,
                WINDOW_WIDTH, WINDOW_HEIGHT,
                SDL.SDL_WindowFlags.SDL_WINDOW_SHOWN);

            IntPtr renderer = SDL.SDL_CreateRenderer(window, -1, SDL.SDL_RendererFlags.SDL_RENDERER_SOFTWARE);

            SDL.SDL_SetRenderDrawColor(renderer, 0, 0, 0, 255);
            SDL.SDL_RenderClear(renderer);

            // Desenha o triângulo de apresentação
            SDL.SDL_SetRenderDrawColor(renderer, 255, 204, 0, 255);

            SDL.SDL_RenderDrawLine(renderer, vertices[0, 0], vertices[0, 1], vertices[1, 0], vertices[1, 1]);
            SDL.SDL_RenderDrawLine(renderer, vertices[1, 0], vertices[1, 1], vertices[2, 0], vertices[2, 1]);
            SDL.SDL_RenderDrawLine(renderer, vertices[2, 0], vertices[2, 1], vertices[0, 0], vertices[0, 1]);

            SDL.SDL_RenderPresent(renderer);

            // Seleciona uma vértice aleatória dentro do triângulo utilizando coordenadas baricêntricas
            Random random = new Random();

            double r1 = random.NextDouble();
            double r2 = random.NextDouble();

            if (r1 + r2 > 1)
            {
                r1 = 1 - r1;
                r2 = 1 - r2;
            }

            double r3 = 1 - r1 - r2;

            int x = (int)(r1 * vertices[0, 0] + r2 * vertices[1, 0] + r3 * vertices[2, 0]);
            int y = (int)(r1 * vertices[0, 1] + r2 * vertices[1, 1] + r3 * vertices[2, 1]);

            // Loop de execução

            SDL.SDL_Event e;

            bool isRunning = true;

            while (isRunning)
            {
                while (SDL.SDL_PollEvent(out e) != 0)
                {
                    if (e.type == SDL.SDL_EventType.SDL_QUIT)
                    {
                        isRunning = false;
                    }
                }

                SDL.SDL_SetRenderDrawColor(renderer, 255, 204, 0, 255);

                SDL.SDL_RenderDrawPoint(renderer, x, y);

                int randVertex = random.Next(0, 3);

                int vertexX = vertices[randVertex, 0];
                int vertexY = vertices[randVertex, 1];

                x = (vertexX + x) / 2;
                y = (vertexY + y) / 2;

                SDL.SDL_RenderPresent(renderer);

                //(Opcional) Adicionar um delay para exibir os pontos
                //SDL.SDL_Delay(10);
            }

            SDL.SDL_DestroyRenderer(renderer);
            SDL.SDL_DestroyWindow(window);
            SDL.SDL_Quit();
        }
    }
}
