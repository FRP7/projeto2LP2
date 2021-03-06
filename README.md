# Projeto 2

 **Francisco Pires a21804873:**
 - Planeamento, estrutura��o, organiza��o e gest�o do projeto.
 - `GameLoop`, `GameState`, `RenderEngine`, `UserInput`, `Food`, `FoodObject` , `GameObject`,
 `SceneObject`, `SnakeObject`, `SnakePart`, `Direction`, `Facade`.
 - Movimento da cobra.
 - Cen�rio.
 - *Polishing* e documenta��o do c�digo.
 - Corre��o de *bugs*.
 - Relat�rio.
 
 **Nuno Figueiredo a21705451:**
 - `GameOver`.
 - `Intro`.
 - `Menu`.
 - `SplashScreen`.

 **Andr� Cosme a21802129:**
 - Colis�es. 
 - Comida.
 
 **Reposit�rio**: https://github.com/FRP7/projeto2LP2
# Arquitetura da solu��o

**Descri��o breve da solu��o:**

Esta solu��o tem como objetivo replicar o jogo cl�ssico *Snake*, utilizando
boas pr�ticas de programa��o orientadas a objetos com base na mat�ria que
aprendemos em LP2. 

**Organiza��o:**

A solu��o foi feita tentando sempre que poss�vel respeitar os princ�pios 
*SOLID* (especialmente o *Single-responsibility principle*), e para isso 
utliz�mos como *Design Pattern* o *GameLoop pattern,* o *Update pattern*,
o *Component pattern* e o *Facade pattern*. 
Os tr�s primeiros *patterns* foram utilizados para manter o c�digo do jogo
organizado, compreens�vel e profissional, e o �ltimo, foi utilizado para manter
o c�digo menos *esparguete*, visto que existem muitas intera��es entre
ficheiros. 
O projeto foi organizado de forma que seja parecido com o *Unity* para 
facilitar a sua compreens�o e trabalho.

**A cobra.**

Para  criar a cobra, criei um *GameObject* dela e uma classe que representa uma
parte dela (como se a cobra fosse feita de *Lego* e a parte fosse uma das suas 
pe�as), e nela cont�m as suas coordenadas e o seu *sprite*.  Depois criei uma
Cole��o (neste caso uma *List*) de partes da cobra para representar o seu 
corpo. Tamb�m criei uma vari�vel que aponta para a cabe�a e outra para a cauda
da cobra (atrav�s do `LINQ`).
Para criar o movimento, criei um `enum` para indicar as dire��es poss�veis 
(visto que segundo as regra do jogo original, a cobra n�o pode mover na dire��o
oposta a que anda) e as coordenadas da cobra s�o modificadas ao longo do jogo
de acordo com o `enum` escolhido (que � escolhido atrav�s do *input* do 
jogador). Para o aspeto do movimento parecer de uma cobra, sempre que ela move,
vai removendo pe�as da Cole��o e depois volta a meter.
A cobra colide comparando as suas coordenadas atuais com as dos objetos que
queremos que haja colis�o, e caso coma a comida, � acrescentado mais uma pe�a �
sua Cole��o de forma a aumentar o tamanho do corpo.

**A comida.**

A comida tal como a cobra, aparece num s�tio fixo no in�cio do jogo, e depois
ao longo do jogo, sempre que � comida pela cobra, nasce num s�tio aleat�rio. O
sistema de *spawn*, est� preparado de forma que gere a comida em s�tios legais
do jogo (ou seja, n�o em cima dos muros) e de forma din�mica (caso queiramos 
mudar o tamanho do cen�rio).

**O cen�rio.**

O cen�rio tal como a comida e a cobra, � um *GameObject* e � din�mico ou seja,
podemos mudar o tamanho dele sem sofrer problemas no jogo (no qual os outros
*GameObject* est�o preparados para isso tamb�m).
O cen�rio � est�tico mas, tem que ser atualizado em todos os *frames* de forma 
a manter o movimento da cobra na forma que n�s queremos.


**UML:**



![image](P2_LP2_UML.JPG)


**Flowchart:**



![image](P2_LP2_FLOW.JPG)



## Refer�ncias

Para criar o movimento da cobra, inspirei-me nesta solu��o no *StackOverflow*: 
https://stackoverflow.com/questions/33924505/c-sharp-console-application-moving-a-character

```cs
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

Para detetar a colis�o da cobra consigo mesma, eu e o Andr� inspir�mo-nos nesta
solu��o no *StackOverflow*:
https://stackoverflow.com/questions/21203601/collision-detection-simple-snake-game
```cs
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
```cs
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

Tamb�m consult�mos os slides das aulas e a documenta��o do C# da *Microsoft*.