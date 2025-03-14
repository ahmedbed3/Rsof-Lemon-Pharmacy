# Rsof-Lemon-Pharmacy
# Project Structure
# Branch Guide
Follow these steps for branch management:

Create a new branch from develop.

Branch Naming Convention:
Use the format: [Task Type]/[Task Id]-[Task Name].
Example: bugfix/001-create-api.

Pull Requests:
Create pull requests against the develop branch.

Documentation:
Create a flow diagram or sequence diagram for each ticket.

# Database Migration
To create a new database migration, execute the following commands in sequence:

Run the following command to add a migration:

dotnet ef migrations add initialCommit --project ./lemonPharmacy.InfraStructure --startup-project ./lemonPharmacy

dotnet ef database update --project ./lemonPharmacy.InfraStructure --startup-project ./lemonPharmacy



