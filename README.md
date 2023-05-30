# What I did
1.Created SQL Store Procedure with recursion for the Properties table<br>
  -Made recursion from parentId column to Id column<br>
  -Select the necessary column and store the query in procedure 

2.Setting up the API route<br>
  -Made Export endpoint, type GET<br>
  -Connect to the DB from the Export endpoint and call the store procedure<br>
  -Store the response from the DB
  
3.Tree structure<br>
  -Made a simple Node class with all the properties from the DB response<br>
  -And created a fucntion add add all the child Nodes to their parent Nodes
  
4.Display the data<br>
  -Call the endpoint from the frontend and deserialize the response<br>
  -Create reusable component with the @helper and loop through the response<br>
  -Format the data in plain text and raw html
