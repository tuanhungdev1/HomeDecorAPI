using System;

namespace HomeDecorAPI.Application.Shared.Messages {
    public static class SuccessMessages {
        public static class Entity {
            public static string Created(string entityName, object entityId) => $"{entityName} with ID {entityId} was successfully created.";
            public static string Fetched(string entityName, object entityId) => $"{entityName} with ID {entityId} was successfully fetched.";
            public static string Updated(string entityName, object entityId) => $"{entityName} with ID {entityId} was successfully updated.";
            public static string Deleted(string entityName, object entityId) => $"{entityName} with ID {entityId} was successfully deleted.";
            public static string Retrieved(string entityName) => $"{entityName} data was successfully retrieved.";
            public static string ListRetrieved(string entityName) => $"List of {entityName}s was successfully retrieved.";
            public static string ItemAdded(string productId, string listName, string userId) => $"Product with ID {productId} was successfully added to user with ID {userId}'s {listName}.";
            public static string ItemFetched(string productId, string listName, string userId) => $"Product with ID {productId} was successfully fetched from user with ID {userId}'s {listName}.";
            public static string ItemUpdated(string productId, string listName, string userId) => $"Product with ID {productId} in user with ID {userId}'s {listName} was successfully updated.";
            public static string ItemRemoved(string productId, string listName, string userId) => $"Product with ID {productId} was successfully removed from user with ID {userId}'s {listName}.";
            public static string AllItemsDeleted(string entityName) =>
            $"All items of {entityName} were successfully deleted.";

        }

        public static class Authentication {
            public static string Success => "Authentication successful.";
            public static string UserLoggedIn(string username) => $"User with username {username} has logged in successfully.";
            public static string TokenGenerated(string username) => $"Authentication token generated for user {username}.";
            public static string TokenRefreshed => "Authentication token has been refreshed.";
            public static string UserLoggedOut(string username) => $"User with username {username} has logged out successfully.";
        }

       
    }
}
