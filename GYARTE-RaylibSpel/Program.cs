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
Texture2D ButtonImage = Raylib.LoadTexture("GreenButton.png");
Texture2D ButtonImage1 = Raylib.LoadTexture("RedButton.png");




// Image Base
Rectangle gameRect = new Rectangle(700, 400, 30, 30);
Rectangle gameRect1 = new Rectangle(200, 140, 400, 500);
Rectangle gameRect2 = new Rectangle(800, 140, 400, 500);
Rectangle gameRect3 = new Rectangle(150, 100, 500, 320);
Rectangle gameRect4 = new Rectangle(200, 450, 400, 120);
Rectangle gameRect5 = new Rectangle(700, 450, 400, 120);

// Collision Rec
Rectangle r1 = new Rectangle(gameRect1.x, gameRect1.y, 400, 500);
Rectangle r2 = new Rectangle(gameRect2.x, gameRect2.y, 400, 500);
Rectangle r4 = new Rectangle(gameRect4.x, gameRect4.y, 400, 500);
Rectangle r5 = new Rectangle(gameRect5.x, gameRect5.y, 400, 500);



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

else if ( slide == "choiceEvil") {
        Raylib.ClearBackground(Color.MAROON);

}

else if ( slide == "choiceGood") {
        Raylib.ClearBackground(Color.GOLD);

}



    // Cursor W/A/S/D Interact: E
    Raylib.DrawRectangleRec(gameRect, Color.WHITE);
    Raylib.DrawTexture(CursorImage, (int)gameRect.x, (int)gameRect.y, Color.WHITE);

    // End
    Raylib.EndDrawing();
}







