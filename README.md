# Projeto 2

 **Francisco Pires a21804873:**
 - Planeamento, estruturação, organização e gestão do projeto.
 - `GameLoop`, `Update`, `Render` e `GameObjects`. 
 - Movimento da cobra.
 - Cenário.
 - Colisões e comida (feito em equipa com o André via *Discord*).
 - *Polishing* e documentação do código.
 - Correção de *bugs*.
 - Relatório.
 
 **Nuno Figueiredo a21705451:**
 - `Menu`.
 - `Intro`.
 - `GameOver`.

 **André Cosme a21802129:**
 - Colisões e comida (feito em equipa com o Francisco via *Discord*).
 
 **Repositório**: https://github.com/FRP7/projeto2LP2
# Arquitectura da solução

**Descrição breve da solução:**

Esta solução tem como objetivo replicar o jogo clássico *Snake*, utilizando
boas práticas de programação orientadas a objetos com base na matéria que
aprendemos em LP2. 

**Organização:**

A solução foi feita tentando sempre que possível respeitar os princípios 
*SOLID* (especialmente o *Single-responsibility principle*), e para isso 
utlizámos como *Design Pattern* o *GameLoop pattern,* o *Update pattern*,
o *Component pattern* e o *Facade pattern*. 
Os três primeiros *patterns* foram utilizados para manter o código do jogo
organizado, compreensível e profissional, e o último, foi utilizado para manter
o código menos *esparguete*, visto que existem muitas interações entre
ficheiros. 
O projeto foi organizado de forma que seja parecido com o *Unity* para 
facilitar a sua compreensão e trabalho.

**A cobra.**

Para  criar a cobra, criei um *GameObject* dela e uma classe que representa uma
parte dela (como se a cobra fosse feita de *Lego* e a parte fosse uma das suas 
peças), e nela contêm as suas coordenadas e o seu *sprite*.  Depois criei uma
Coleção (neste caso uma *List*) de partes da cobra para representar o seu 
corpo. Também criei uma variável que aponta para a cabeça e outra para a cauda
da cobra (através do `LINQ`).
Para criar o movimento, criei um `enum` para indicar as direções possíveis 
(visto que segundo as regra do jogo original, a cobra não pode mover na direção
oposta a que anda) e as coordenadas da cobra são modificadas ao longo do jogo
de acordo com o `enum` escolhido (que é escolhido através do *input* do 
jogador). Para o aspeto do movimento parecer de uma cobra, sempre que ela move,
vai removendo peças da Coleção peças e depois volta a meter.
A cobra colide comparado as suas coordenadas atuais com as dos objetos que
queremos que haja colisão, e caso coma a comida, é acrescentado mais uma peça à
sua Coleção de forma a aumentar o tamanho do corpo.

**A comida.**

A comida tal como a cobra, aparece num sítio fixo no início do jogo, e depois
ao longo do jogo, sempre que é comida pela cobra, nasce num sítio aleatório. O
sistema de *spawn*, está preparado de forma que gere a comida em sítios legais
do jogo (ou seja, não em cima dos muros) e de forma dinâmica (caso queiramos 
mudar o tamanho do cenário).

**O cenário.**

O cenário tal como a comida e a cobra, é um *GameObject* e é dinâmico ou seja,
podemos mudar o tamanho dele sem sofrer problemas no jogo (que na qual o outros
*GameObject* estão preparados para isso também).
O cenário é estático mas, tem que ser atualizado em todos os *frames* de forma 
a manter o movimento da cobra na forma que nós queremos.


**UML:**



![image](P2_LP2_UML.jpg)


**Flowchart:**



![image](inserirflowchart.jpg)



## Referências

Para criar o movimento da cobra, inspirei-me neste solução no *StackOverflow*: 
https://stackoverflow.com/questions/33924505/c-sharp-console-application-moving-a-character

```
public class Program
{
    public static void Main(string[] args)
    {
        const char toWrite = '*'; // Character to write on-screen.

        int x = 0, y = 0; // Contains current cursor position.

        Write(toWrite); // Write the character on the default location (0,0).

        while (true)
        {
            if (Console.KeyAvailable)
            {
                var command = Console.ReadKey().Key;

                switch (command)
                {
                    case ConsoleKey.DownArrow:
                        y++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 0)
                        {
                            y--;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (x > 0)
                        {
                            x--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        x++;
                        break;
                }

                Write(toWrite, x, y);
            }
            else
            {
                Thread.Sleep(100);
            }
        }
    }

    public static void Write(char toWrite, int x = 0, int y = 0)
    {
        try
        {
            if (x >= 0 && y >= 0) // 0-based
            {
                Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write(toWrite);
            }
        }
        catch (Exception)
        {
        }
    }
}
```

Para detetar a colisão da cobra consigo mesma, eu e o André inspirámos nesta
solução no *StackOverflow*:
https://stackoverflow.com/questions/21203601/collision-detection-simple-snake-game
```
// line 32
if (game.snakes.length !== 0) {
    for (i = 0; i < game.snakes.length; i++) {
        var s = game.snakes[i];
        s.paint(ctx, game);

        // Check for collision.
        if (s.collision()) {
            // Do something, if the collision happens.
            alert('collision');
        }
    }
}
```
```
Snake.prototype.collision = function () {
    // Loop the snake pieces from the 4th one.
    for(var i = 3; i < this.length; i++){
        // Check if this piece collides with the first piece.
        if(
            this.pieces[0].x === this.pieces[i].x &&
            this.pieces[0].y === this.pieces[i].y
        ) {
            return true; // collision
        }
    }   
    return false;
};
```
Para o Nuno criar o texto da *intro* facilmente, ele utilizou este website para
gerar o texto nesse estilo:
https://patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20