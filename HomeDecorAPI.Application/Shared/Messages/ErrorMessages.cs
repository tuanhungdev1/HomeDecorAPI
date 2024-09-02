using System;

namespace HomeDecorAPI.Application.Shared.Messages {
    public static class ErrorMessages {
        public static class Entity {
            public static string NotFound(string entityName, object entityId) => $"{entityName} with ID {entityId} was not found.";
            public static string CreationFailed(string entityName) => $"Failed to create {entityName}.";
            public static string UpdateFailed(string entityName, object entityId) => $"Failed to update {entityName} with ID {entityId}.";
            public static string DeletionFailed(string entityName, object entityId) => $"Failed to delete {entityName} with ID {entityId}.";
            public static string InvalidRequest(string entityName) => $"The request for {entityName} is invalid.";

            public static string ItemNotFound(string entityName, string productId, string userId) =>
             $"{entityName} item with ID {productId} for user with ID {userId} was not found.";

            public static string ItemAlreadyExists(string entityName, string productId, string userId) =>
                $"{entityName} item with ID {productId} already exists for user with ID {userId}.";

            public static string ItemCreationFailed(string entityName, string userId) =>
                $"Failed to create {entityName} for user with ID {userId}.";

            public static string ItemUpdateFailed(string entityName, string productId, string userId) =>
                $"Failed to update {entityName} item with ID {productId} for user with ID {userId}.";

            public static string ItemDeletionFailed(string entityName, string userId) =>
                $"Failed to delete all {entityName} for user with ID {userId}.";
        }

        public static class Authentication {
            public static string Failed(string reason) => $"Authentication failed: {reason}.";
            public static string UserNotFound(string username) => $"User with username {username} was not found.";
            public static string InvalidCredentials => "Invalid credentials provided.";
            public static string TokenExpired => "Authentication token has expired.";
            public static string TokenInvalid => "Authentication token is invalid.";
            public static string UnauthorizedAccess => "Unauthorized access.";
        }

        
    }
}
