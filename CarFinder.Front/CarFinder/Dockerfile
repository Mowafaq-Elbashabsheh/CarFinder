# --- Build Stage ---
FROM node:20 AS build
WORKDIR /app

# Copy package.json and install dependencies
COPY package*.json ./
RUN npm install

# Copy the rest of the Angular source code
COPY . .

# Build the Angular app for production
RUN npm run build --prod

# --- Serve Stage ---
FROM nginx:alpine
COPY --from=build /app/dist/CarFinder /usr/share/nginx/html

# Expose port 80 to access the app
EXPOSE 80
