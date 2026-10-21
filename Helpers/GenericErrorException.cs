using System;
using System.Net;
using EvaluacionTecnica.Models.Dto;

namespace EvaluacionTecnica.Helpers
{
    public class GenericErrorException : Exception
    {
        public ErrorMessageDto GenericError { get; }

        public GenericErrorException(ErrorMessageDto genericError, HttpStatusCode statusCode)
        {
            GenericError = genericError;
            StatusCode = statusCode;
        }

        public HttpStatusCode StatusCode { get; set; }
    }
}