﻿using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Esta classe não faz mais nada sem ser iniciar a solução.
    /// Podem utilizar pa testar os métodos do jogo enquanto o menu não estiver
    /// terminado, só peço que não façam add ás alterações desta classe no git.
    /// </summary>
    class Program
    {
        static void Main(string[] args) {
            //Menu menu = new Menu();
            //Console.WriteLine("Entrar na solução.");
            //menu.MainMenu();
            // testar cenas
            SceneRender sceneRender = new SceneRender();
            sceneRender.RenderScene();
        }
    }
}
