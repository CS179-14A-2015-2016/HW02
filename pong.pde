//Ball
float ballSize = 6;
float ballX;
float ballY;
float ballSpeedX = random (2, 3); //initializes speed along x
float ballSpeedY = random (2, 3); //initializes speed along y
//Paddle height
float paddleHeight = 50;
//Paddle width
float paddleWidth = 5;
//Paddle Speed
float pSpeed = 30;
//Left Paddle 
float paddleLeftY;
float paddleLeftX;
//Right Paddle 
float paddleRightY;
float paddleRightX;
//buffer(so paddles aren't hitting edge of screen
float buffer = 20;
// Score
int Left = 0;
int Right = 0;

//start
boolean FREEZE = true;


void setup() {
  size(480, 360);
  background(0);
  
  //draws ball in center of the map
  ballX = width/2;
  ballY = height/2;

  //paddle left
  paddleLeftY = height/2-paddleHeight/2;
  paddleLeftX = buffer;
  
  //paddle right
  paddleRightY = height/2-paddleHeight/2;
  paddleRightX = width- buffer;
}
 
void draw() {
  
  //Start Screen
  if(FREEZE == true){ 
  frame.setTitle("P0NG - Press ENTER TO START");
  }else{
  frame.setTitle("P0NG");
  }
  
  // background
  noStroke();
  fill(0);
  rectMode(CORNER);
  rect(0, 0, width, height);
  
  //score
  noStroke();
  fill(255);
  textSize(20);
  textAlign(LEFT);
  text(Left, 50, 50);
  textAlign(RIGHT);
  text(Right, width-50, 50);
 
  // ball
  noStroke();
  fill(255);
  rectMode(CENTER);
  ellipse(ballX, ballY, ballSize, ballSize);
  
  // Paddles
  noStroke();
  fill(255);
  rectMode(CORNER);
  rect(paddleLeftX, paddleLeftY, paddleWidth, paddleHeight);
  rect(paddleRightX, paddleRightY, paddleWidth, paddleHeight);
  
  //right side bound
  if (ballX > width) {
    ballSpeedX = -ballSpeedX;
    Left++;
    reset();
  }
  
  if (rightpaddleCollision()) {
  ballSpeedX = -ballSpeedX;
  }

  //left side bound
  if (ballX < 0) {
    ballSpeedX = -ballSpeedX;
    Right++;
    reset();
  }   
  
  if (leftpaddleCollision()) {
  ballSpeedX = -ballSpeedX;
  }
  
  //upper side bound
  if (ballY > height) {
    ballSpeedY = -ballSpeedY;
  }
  
  //lower side bound
  if (ballY < 0) {
    ballSpeedY = -ballSpeedY;
  } 
  if(Left == 5 || Right ==5){
  endCheck(); //see function below
  }
  if(FREEZE == true){
  ballSpeedX = 0;
   ballSpeedY = 0;
  }else{
  //makes the ball move
  ballX = ballX + ballSpeedX;
  ballY = ballY + ballSpeedY;}
}
 
void keyPressed() {
  //key detection, in-built
  if (key == CODED){
    if (keyCode == UP) {      
      paddleRightY = paddleRightY - pSpeed;
    } else if (keyCode == DOWN) {      
      paddleRightY =paddleRightY + pSpeed;
    }
  }
  
  if (key == 'W' || key == 'w') {
    paddleLeftY = paddleLeftY - pSpeed;
  } else if (key == 'S' || key == 's') {
    paddleLeftY = paddleLeftY + pSpeed;
  }
  
   if (key == 'R' || key == 'r' ) {
      restart();
  }
  if(key == ENTER){
    if(FREEZE == true){
      FREEZE = false;
      restart();
    }
  }
}

//checks collision with left paddle
boolean leftpaddleCollision() {
  if ((ballX >= paddleLeftX) && (ballX <= paddleLeftX + paddleWidth)) {
    if ((ballY >= paddleLeftY) && (ballY <= paddleLeftY + paddleHeight)) {
    return true;
    }
  }
 return false;
}

//check collision with right paddle
boolean rightpaddleCollision() {
  if ((ballX >= paddleRightX) && (ballX <= paddleRightX + paddleWidth)) {
    if ((ballY >= paddleRightY) && (ballY <= paddleRightY + paddleHeight)) {
    return true;
    }
  }
 return false;
}

//reset ball position
void reset(){
  ballX = width/2;
  ballY = height/2;
}

//check if target score is reached
void endCheck(){
  //stops the ball
  ballX = width/2;
  ballY = height/2;
  ballSpeedX = 0;
  ballSpeedY = 0;
  
  //checks which side won
  if (Left == 5)
  {   
    //score
    noStroke();
    fill(255);
    textSize(30);
    textAlign(CENTER);
    text("Left Player Wins", width/2, height - 50);
    textSize(20);
    text("Press R to restart", width/2, height - 20);
  } else if (Right == 5) {
    //score
    noStroke();
    fill(255);
    textSize(30);
    textAlign(CENTER);
    text("Right Player Wins", width/2, height - 50);
    textSize(20);
    text("Press R to restart", width/2, height - 20);
  }
}

//restarts the game
void restart(){
  Left = 0;
  Right = 0;
  ballSpeedX = random (2, 3); 
  ballSpeedY = random (2, 3);
  
}

