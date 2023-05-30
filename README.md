# What I did
1.Created SQL Store Procedure with recursion for the Properties table
  -Made recursion from parentId column to Id column
  -Select the necessary column and store the query in procedure 

2.Setting up the API route
  -Made Export endpoint, type GET
  -Connect to the DB from the Export endpoint and call the store procedure
  -Store the response from the DB
  
3.Tree structure
  -Made a simple Node class with all the properties from the DB response 
  -And created a fucntion add add all the child Nodes to their parent Nodes
  
4.Display the data
  -Call the endpoint from the frontend and deserialize the response
  -Create reusable component with the @helper and loop through the response
  -Format the data in plain text and raw html
