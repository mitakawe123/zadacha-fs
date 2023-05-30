# What I did
1.Created SQL Store Procedure with recursion for the Properties table<br>
  &ensp;-Made recursion from parentId column to Id column<br>
  &ensp;-Select the necessary column and store the query in procedure 

2.Setting up the API route<br>
  &ensp;-Made Export endpoint, type GET<br>
  &ensp;-Connect to the DB from the Export endpoint and call the store procedure<br>
  &ensp;-Store the response from the DB
  
3.Tree structure<br>
  &ensp;-Made a simple Node class with all the properties from the DB response<br>
  &ensp;-And created a fucntion add add all the child Nodes to their parent Nodes
  
4.Display the data<br>
  &ensp;-Call the endpoint from the frontend and deserialize the response<br>
  &ensp;-Create reusable component with the @helper and loop through the response<br>
  &ensp;-Format the data in plain text and raw html
