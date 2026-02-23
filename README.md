# Apex Clothiers API Documentation

## Setup Instructions

1. **Clone the Repository**  
   ```bash
   git clone https://github.com/YourUsername/apex-custom-clothiers.git
   cd apex-custom-clothiers
   ```

2. **Install Dependencies**  
   Make sure to have Node.js and npm installed, then run:  
   ```bash
   npm install
   ```

3. **Configure Environment Variables**  
   Create a `.env` file based on the `.env.example` and fill in the necessary variables.

4. **Run the Application**  
   ```bash
   npm start
   ```


## API Endpoints

### 1. Get All Products
- **Endpoint**: `/api/products`
- **Method**: `GET`
- **Description**: Fetch all products from the database.

### 2. Get a Product by ID
- **Endpoint**: `/api/products/:id`
- **Method**: `GET`
- **Description**: Fetch a single product by its ID.

### 3. Create a New Product
- **Endpoint**: `/api/products`
- **Method**: `POST`
- **Description**: Create a new product in the database.
- **Body**:  
   ```json
   {
     "name": "string",
     "price": "number",
     "description": "string"
   }
   ```


## Database Setup

1. **Install Database**  
   Choose a database (e.g., MongoDB, MySQL) and install it according to your preference.

2. **Create a Database**  
   Create a new database for the Apex Clothiers application.

3. **Migrate Database**  
   Run the migration commands to set up the initial schema:
   ```bash
   npm run migrate
   ```

4. **Seed Database** (Optional)  
   If you want to seed the database with initial data, run:
   ```bash
   npm run seed
   ```