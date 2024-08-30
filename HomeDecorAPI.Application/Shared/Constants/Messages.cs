using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeDecorAPI.Application.Shared.Constants {
    public static class Messages {
        private static string FormatMessage(string message, params object[] args) {
            return string.Format(message, args);
        }

        public static class Error {
            public const string InvalidInput = "Invalid input: {0}";
            public const string AccessDenied = "Access denied. You do not have permission to perform this action.";
            public const string OperationFailed = "The operation failed. Please try again later.";
            public const string DatabaseError = "A database error occurred: {0}";
            public const string InvalidCredentials = "Invalid username or password.";
            public const string NotFound = "{0} with ID {1} was not found.";
            public const string AlreadyExists = "{0} '{1}' already exists.";
            public const string OutOfStock = "The requested {0} is out of stock.";
            public const string InvalidPrice = "Invalid {0} price: {1}. Price must be greater than zero.";
            public const string Unauthorized = "Unauthorized access. Please log in.";
            public const string TokenExpired = "Your session has expired. Please log in again.";

            public static string EntityNotFound(string entityName, int id) => FormatMessage(NotFound, entityName, id);
            public static string DuplicateEntity(string entityName, string value) => FormatMessage(AlreadyExists, entityName, value);
            public static string ItemOutOfStock(string itemName) => FormatMessage(OutOfStock, itemName);
            public static string InvalidEntityPrice(string entityName, decimal price) => FormatMessage(InvalidPrice, entityName, price);
        }

        public static class Success {
            public const string OperationSuccessful = "The operation was completed successfully.";
            public const string EntityCreated = "{0} was successfully created.";
            public const string EntityUpdated = "{0} was successfully updated.";
            public const string EntityDeleted = "{0} was successfully deleted.";
            public const string PasswordChanged = "Password was successfully changed.";
            public const string PasswordReset = "Password reset instructions have been sent to your email.";
            public const string OrderPlaced = "Order with ID {0} was successfully placed.";
            public const string OrderShipped = "Order with ID {0} has been shipped.";
            public const string LoginSuccessful = "You have successfully logged in.";
            public const string LogoutSuccessful = "You have successfully logged out.";

            public static string EntityAction(string action, string entityName, string identifier) => FormatMessage($"{entityName} with {identifier} was successfully {action}.");
        }

        public static class Info {
            public const string WelcomeMessage = "Welcome, {0}!";
            public const string NoDataAvailable = "No data available.";
            public const string LoadingData = "Loading data, please wait...";
            public const string SearchResults = "Found {0} results for '{1}'.";
            public const string PasswordRequirements = "Password must be at least 8 characters long and include uppercase, lowercase, number, and special character.";
            public const string EmailVerificationSent = "A verification email has been sent. Please check your inbox.";
            public const string LowStock = "Low stock alert: {0} has only {1} units left.";
            public const string OrderStatus = "Order {0} status: {1}";
            public const string MaintenanceScheduled = "System maintenance is scheduled for tonight at 2 AM UTC.";

            public static string WelcomeUser(string username) => FormatMessage(WelcomeMessage, username);
            public static string SearchResult(int count, string query) => FormatMessage(SearchResults, count, query);
            public static string LowStockAlert(string productName, int quantity) => FormatMessage(LowStock, productName, quantity);
            public static string OrderStatusUpdate(Guid id, string status) => FormatMessage(OrderStatus, id, status);
        }

        public static class Warning {
            public const string ActionIrreversible = "This action is irreversible. Are you sure you want to proceed?";
            public const string UnsavedChanges = "You have unsaved changes. Are you sure you want to leave this page?";
            public const string WeakPassword = "The provided password is weak. Consider using a stronger password.";
            public const string AccountInactive = "Account '{0}' is inactive. Please contact support.";
            public const string ProductNearlyOutOfStock = "Warning: {0} is nearly out of stock.";
            public const string LargeOrderWarning = "This is a large order. Please verify all details before confirming.";
            public const string HighSystemLoad = "The system is experiencing high load. Some operations may be slower than usual.";

            public static string InactiveAccount(string username) => FormatMessage(AccountInactive, username);
            public static string NearlyOutOfStock(string productName) => FormatMessage(ProductNearlyOutOfStock, productName);
        }
    }
}
