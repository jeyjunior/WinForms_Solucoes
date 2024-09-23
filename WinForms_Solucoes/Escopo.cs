WFGerenciar.Shared
│
├── Application
│   └── (Serviços e lógica de aplicação que podem ser reutilizados)
│
├── Database
│   ├── ConnectionManager.cs        // Gerencia conexões com o banco de dados
│   └── DbContext.cs (opcional)     // Contexto do banco de dados, se aplicável
│
├── Extensions
│   ├── GenericExtensions.cs        // Métodos de extensão para tipos primitivos e coleções
│   └── WindowsFormsExtensions.cs    // Extensões específicas para Windows Forms
│
├── Data
│   ├── RepositoryBase.cs           // Classe base para repositórios
│   └── UnitOfWork.cs               // Implementação do padrão Unit of Work
│
└── Utilities
    ├── FileUtilities.cs             // Métodos utilitários para manipulação de arquivos
    └── SignatureUtilities.cs         // Métodos para lidar com assinaturas em arquivos PDF
