using System;
using Raylib_cs;
using System.Numerics;


Raylib.InitWindow(1400, 800, "GYARTE, Thunderwing Prototyp");
Raylib.SetTargetFPS(60);

string slide = "start";

// Images
Texture2D CursorImage = Raylib.LoadTexture("cursor.png");
Texture2D CharImage = Raylib.LoadTexture("EvilSoldier1.png");
Texture2D Char1Image = Raylib.LoadTexture("GoodElf1.png");
Texture2D PropImage = Raylib.LoadTexture("BurningVillage.png");
Texture2D PropImage1 = Raylib.LoadTexture("burningInside.png");
Texture2D PropImage2 = Raylib.LoadTexture("peopleCamp.png");
Texture2D PropImage3 = Raylib.LoadTexture("doggyinforest.png");
Texture2D PropImage4 = Raylib.LoadTexture("tentcamp.png");
Texture2D ButtonImage = Raylib.LoadTexture("GreenButton.png");
Texture2D ButtonImage1 = Raylib.LoadTexture("RedButton.png");




// Image Base
Rectangle gameRect = new Rectangle(700, 400, 30, 30);
Rectangle gameRect1 = new Rectangle(200, 140, 400, 500);
Rectangle gameRect2 = new Rectangle(800, 140, 400, 500);
Rectangle gameRect6 = new Rectangle(700, 450, 400, 120);
Rectangle gameRect12 = new Rectangle(200, 150, 275, 180);

//buttons
Rectangle gameRect4 = new Rectangle(200, 450, 400, 120);
Rectangle gameRect5 = new Rectangle(700, 450, 400, 120);
Rectangle gameRect9 = new Rectangle(765, 495, 400, 120);
Rectangle gameRect10 = new Rectangle(765, 650, 400, 120);
Rectangle gameRect13 = new Rectangle(765, 650, 400, 120);
Rectangle gameRect14 = new Rectangle(765, 650, 400, 120);
Rectangle gameRect15 = new Rectangle(765, 650, 400, 120);
Rectangle gameRect16 = new Rectangle(765, 650, 400, 120);
Rectangle gameRect17 = new Rectangle(765, 650, 400, 120);
Rectangle gameRect18 = new Rectangle(765, 650, 400, 120);


//PropBackground
Rectangle gameRect3 = new Rectangle(150, 100, 500, 320);
Rectangle gameRect7 = new Rectangle(30, 370, 690, 400);
Rectangle gameRect8 = new Rectangle(40, 300, 619, 400);
Rectangle gameRect11 = new Rectangle(150, 100, 340, 150);

// Collision Rec
Rectangle r1 = new Rectangle(gameRect1.x, gameRect1.y, 400, 500);
Rectangle r2 = new Rectangle(gameRect2.x, gameRect2.y, 400, 500);
Rectangle r4 = new Rectangle(gameRect4.x, gameRect4.y, 400, 500);
Rectangle r5 = new Rectangle(gameRect5.x, gameRect5.y, 400, 500);
Rectangle r9 = new Rectangle(gameRect9.x, gameRect9.y, 400, 500);
Rectangle r10 = new Rectangle(gameRect10.x, gameRect10.y, 400, 500);
Rectangle r11 = new Rectangle(gameRect11.x, gameRect11.y, 400, 500);
Rectangle r12 = new Rectangle(gameRect12.x, gameRect12.y, 400, 500);
Rectangle r13 = new Rectangle(gameRect13.x, gameRect13.y, 400, 500);
Rectangle r14 = new Rectangle(gameRect14.x, gameRect14.y, 400, 500);
Rectangle r15 = new Rectangle(gameRect15.x, gameRect15.y, 400, 500);
Rectangle r16 = new Rectangle(gameRect16.x, gameRect16.y, 400, 500);
Rectangle r17 = new Rectangle(gameRect17.x, gameRect17.y, 400, 500);
Rectangle r18 = new Rectangle(gameRect18.x, gameRect18.y, 400, 500);




slide = "1";

// int countdown = 0;


while (!Raylib.WindowShouldClose())
{

    // Start
    Raylib.BeginDrawing();

    if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
    {
        gameRect.x -= 5;
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
    {
        gameRect.y += 5;
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
    {
        gameRect.x += 5;
    }

    if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
    {
        gameRect.y -= 5;
    }

    if (slide == "1")
    {
        Raylib.ClearBackground(Color.WHITE);


        Raylib.DrawRectangleRec(gameRect1, Color.WHITE);
        Raylib.DrawTexture(CharImage, (int)gameRect1.x, (int)gameRect1.y, Color.WHITE);

        Raylib.DrawRectangleRec(gameRect2, Color.WHITE);
        Raylib.DrawTexture(Char1Image, (int)gameRect2.x, (int)gameRect2.y, Color.WHITE);


        Vector2 mousePos = Raylib.GetMousePosition();

        if (Raylib.CheckCollisionPointRec(mousePos, r1))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "slideEvil";
            }
        }
        if (Raylib.CheckCollisionPointRec(mousePos, r2))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "slideGood";
            }
        }
        if (Raylib.CheckCollisionRecs(r1, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "slideEvil";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }
        if (Raylib.CheckCollisionRecs(r2, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "slideGood";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }
    }

    else if (slide == "slideEvil")
    {
        Raylib.ClearBackground(Color.MAROON);
        Raylib.DrawText("Du är ond!", 700, 100, 40, Color.LIGHTGRAY);
        Raylib.DrawText("Du marcherar med din Armé\n och hittar en brinnande by!", 700, 250, 40, Color.BLACK);


        Raylib.DrawRectangleRec(gameRect3, Color.WHITE);
        Raylib.DrawTexture(PropImage, (int)gameRect3.x, (int)gameRect3.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect4, Color.WHITE);
        Raylib.DrawTexture(ButtonImage, (int)gameRect4.x, (int)gameRect4.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect5, Color.WHITE);
        Raylib.DrawTexture(ButtonImage1, (int)gameRect5.x, (int)gameRect5.y, Color.WHITE);

        Raylib.DrawText("Gå in i Byn.", 265, 495, 40, Color.GOLD);
        Raylib.DrawText("Gå förbi byn.", 765, 495, 40, Color.BLACK);
        Vector2 mousePos = Raylib.GetMousePosition();

        if (Raylib.CheckCollisionPointRec(mousePos, r4))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "choiceGood";
            }
        }
        if (Raylib.CheckCollisionPointRec(mousePos, r5))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "choiceEvil";
            }
        }
        if (Raylib.CheckCollisionRecs(r4, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "choiceGood";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }
        if (Raylib.CheckCollisionRecs(r5, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "choiceEvil";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }

    }

    else if (slide == "slideGood")
    {
        Raylib.ClearBackground(Color.LIGHTGRAY);
        Raylib.DrawText("Du är god!", 700, 100, 40, Color.DARKGREEN);
        Raylib.DrawText("Du marcherar med din Armé\n och hittar en brinnande by!", 700, 230, 40, Color.DARKGREEN);


        Raylib.DrawRectangleRec(gameRect3, Color.WHITE);
        Raylib.DrawTexture(PropImage, (int)gameRect3.x, (int)gameRect3.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect4, Color.WHITE);
        Raylib.DrawTexture(ButtonImage, (int)gameRect4.x, (int)gameRect4.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect5, Color.WHITE);
        Raylib.DrawTexture(ButtonImage1, (int)gameRect5.x, (int)gameRect5.y, Color.WHITE);

        Raylib.DrawText("Gå in i Byn.", 265, 495, 40, Color.GOLD);
        Raylib.DrawText("Gå förbi byn.", 765, 495, 40, Color.BLACK);

        Vector2 mousePos = Raylib.GetMousePosition();

        if (Raylib.CheckCollisionPointRec(mousePos, r4))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "choiceGood";
            }
        }
        if (Raylib.CheckCollisionPointRec(mousePos, r5))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "choiceEvil";
            }
        }
        if (Raylib.CheckCollisionRecs(r4, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "choiceGood";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }
        if (Raylib.CheckCollisionRecs(r5, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "choiceEvil";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }
    }

    else if (slide == "choiceEvil")
    {
        Raylib.ClearBackground(Color.MAROON);
        Raylib.DrawText("Du ignorerade byborna.", 700, 100, 40, Color.DARKGREEN);
        Raylib.DrawText("Du ignorerade byn\n och gick vidare, du kommer\n fram till en grupp personer\n som vilar.", 700, 230, 40, Color.DARKGREEN);


        Raylib.DrawRectangleRec(gameRect8, Color.WHITE);
        Raylib.DrawTexture(PropImage2, (int)gameRect8.x, (int)gameRect8.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect9, Color.WHITE);
        Raylib.DrawTexture(ButtonImage, (int)gameRect9.x, (int)gameRect9.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect10, Color.WHITE);
        Raylib.DrawTexture(ButtonImage1, (int)gameRect10.x, (int)gameRect10.y, Color.WHITE);

        Raylib.DrawText("Du låter dem vara.", 780, 535, 40, Color.GOLD);
        Raylib.DrawText("Du går till attack.", 790, 690, 40, Color.BLACK);
        Vector2 mousePos = Raylib.GetMousePosition();

        if (Raylib.CheckCollisionPointRec(mousePos, gameRect9))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "choiceGood2SEP";
            }
        }
        if (Raylib.CheckCollisionPointRec(mousePos, r10))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "choiceEvil2SEP";
            }
        }
        if (Raylib.CheckCollisionRecs(r9, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "choiceGood2SEP";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }
        if (Raylib.CheckCollisionRecs(r10, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "choiceEvil2SEP";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }

    }

    else if (slide == "choiceGood")
    {
        Raylib.ClearBackground(Color.GOLD);
        Raylib.DrawText("Du gick in i byn!", 700, 100, 40, Color.DARKGREEN);
        Raylib.DrawText("När du kommer in i byn hör du\n en person skrika för hjälp.", 700, 230, 40, Color.DARKGREEN);


        Raylib.DrawRectangleRec(gameRect7, Color.WHITE);
        Raylib.DrawTexture(PropImage1, (int)gameRect7.x, (int)gameRect7.y, Color.WHITE);

        Raylib.DrawRectangleRec(gameRect9, Color.WHITE);
        Raylib.DrawTexture(ButtonImage, (int)gameRect9.x, (int)gameRect9.y, Color.WHITE);

        Raylib.DrawRectangleRec(gameRect10, Color.WHITE);
        Raylib.DrawTexture(ButtonImage1, (int)gameRect10.x, (int)gameRect10.y, Color.WHITE);

        Raylib.DrawText("Du hjälper dem.", 780, 535, 40, Color.GOLD);
        Raylib.DrawText("Du låter dem brinna.", 790, 690, 30, Color.BLACK);
        Vector2 mousePos = Raylib.GetMousePosition();

        if (Raylib.CheckCollisionPointRec(mousePos, gameRect9))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "choiceGood2";
            }
        }
        if (Raylib.CheckCollisionPointRec(mousePos, r10))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "choiceEvil2";
            }
        }
        if (Raylib.CheckCollisionRecs(r9, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "choiceGood2";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }
        if (Raylib.CheckCollisionRecs(r10, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "choiceEvil2";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }
    }

    else if (slide == "choiceEvil2")
    {
        Raylib.ClearBackground(Color.MAROON);
        Raylib.DrawText("Du lät dem brinna?", 700, 100, 40, Color.DARKGREEN);
        Raylib.DrawText("Du är hämsk.", 700, 230, 40, Color.DARKGREEN);
        Raylib.DrawRectangleRec(gameRect3, Color.WHITE);
        Raylib.DrawTexture(PropImage, (int)gameRect3.x, (int)gameRect3.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect4, Color.WHITE);
        Raylib.DrawTexture(ButtonImage, (int)gameRect4.x, (int)gameRect4.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect5, Color.WHITE);
        Raylib.DrawTexture(ButtonImage1, (int)gameRect5.x, (int)gameRect5.y, Color.WHITE);
             Raylib.DrawText("Du försöker hitta någon\n mer att rädda.", 265, 495, 20, Color.GOLD);
        Raylib.DrawText("Du lämnar alla för att dö.", 710, 495, 30, Color.BLACK);
    }

    else if (slide == "choiceGood2")
    {
        Raylib.ClearBackground(Color.YELLOW);
        Raylib.DrawText("Du går och räddar personen!", 700, 100, 40, Color.DARKGREEN);
        Raylib.DrawText("'tack för att du har räddat mig :p'", 700, 230, 35, Color.DARKGREEN);
                Raylib.DrawRectangleRec(gameRect3, Color.WHITE);
        Raylib.DrawTexture(PropImage, (int)gameRect3.x, (int)gameRect3.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect4, Color.WHITE);
        Raylib.DrawTexture(ButtonImage, (int)gameRect4.x, (int)gameRect4.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect5, Color.WHITE);
        Raylib.DrawTexture(ButtonImage1, (int)gameRect5.x, (int)gameRect5.y, Color.WHITE);
             Raylib.DrawText("Du hjälper dem ut ur staden.", 220, 495, 25, Color.GOLD);
        Raylib.DrawText("Du kastar in dem i elden.", 745, 495, 25, Color.BLACK);
    }

    
    else if (slide == "choiceEvil2SEP"){

        Raylib.ClearBackground(Color.MAROON);
        Raylib.DrawText("Du och din armé dödar dem.", 700, 100, 40, Color.DARKGREEN);
        Raylib.DrawText("Du är hämsk.", 700, 230, 40, Color.DARKGREEN);
         Raylib.DrawRectangleRec(gameRect11, Color.WHITE);
        Raylib.DrawTexture(PropImage4, (int)gameRect11.x, (int)gameRect11.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect4, Color.WHITE);
        Raylib.DrawTexture(ButtonImage, (int)gameRect4.x, (int)gameRect5.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect5, Color.WHITE);
        Raylib.DrawTexture(ButtonImage1, (int)gameRect5.x, (int)gameRect5.y, Color.WHITE);
        Raylib.DrawText("Du begraver dem.", 235, 495, 40, Color.GOLD);
        Raylib.DrawText("Ni marscherar\n över kropparna.", 745, 495, 30, Color.BLACK);
       
Vector2 mousePos = Raylib.GetMousePosition();

        if (Raylib.CheckCollisionPointRec(mousePos, gameRect4))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "choiceGood3";
            }
        }
        if (Raylib.CheckCollisionPointRec(mousePos, r5))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "choiceEvil3";
            }
        }
        if (Raylib.CheckCollisionRecs(r4, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "choiceGood3";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }
        if (Raylib.CheckCollisionRecs(r5, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "choiceEvil3";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }

    }
    else if (slide == "choiceGood2SEP"){
        Raylib.ClearBackground(Color.YELLOW);
        Raylib.DrawText("Du går vidare.", 700, 100, 40, Color.DARKGREEN);
        Raylib.DrawText("... Du stöter på en hund valp. ", 700, 230, 40, Color.DARKGREEN);
         Raylib.DrawRectangleRec(gameRect12, Color.WHITE);
        Raylib.DrawTexture(PropImage3, (int)gameRect12.x, (int)gameRect12.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect4, Color.WHITE);
        Raylib.DrawTexture(ButtonImage, (int)gameRect4.x, (int)gameRect4.y, Color.WHITE);
        Raylib.DrawRectangleRec(gameRect5, Color.WHITE);
        Raylib.DrawTexture(ButtonImage1, (int)gameRect5.x, (int)gameRect5.y, Color.WHITE);
        Raylib.DrawText("Du klappar den.", 265, 495, 40, Color.GOLD);
        Raylib.DrawText("Du sparkar hunden.", 715, 495, 35, Color.BLACK);
      
 Vector2 mousePos = Raylib.GetMousePosition();

        if (Raylib.CheckCollisionPointRec(mousePos, gameRect4))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "choiceGood3";
            }
        }
        if (Raylib.CheckCollisionPointRec(mousePos, gameRect5))
        {
            if (Raylib.IsMouseButtonPressed(0))
            {
                slide = "choiceEvil3";
            }
        }
        if (Raylib.CheckCollisionRecs(r4, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "choiceGood3";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }
        if (Raylib.CheckCollisionRecs(r5, gameRect))
        {
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_E))
            {
                slide = "choiceEvil3";
                gameRect.x = 700;
                gameRect.y = 400;
            }
        }
        else if (slide == "choiceEvil3")
        {
 Raylib.ClearBackground(Color.WHITE);
        Raylib.DrawText("Thank you for your time.", 700, 100, 40, Color.DARKGREEN);
        }
       else if (slide == "choiceGood3")
        {
 Raylib.ClearBackground(Color.WHITE);
        Raylib.DrawText("Thank you for your time.", 700, 100, 40, Color.DARKGREEN);
        }
    }


    // Cursor W/A/S/D Interact: E
    Raylib.DrawRectangleRec(gameRect, Color.WHITE);
    Raylib.DrawTexture(CursorImage, (int)gameRect.x, (int)gameRect.y, Color.WHITE);

    // End
    Raylib.EndDrawing();
}

