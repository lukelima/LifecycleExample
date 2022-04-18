# LifecycleExample
Um exemplo de como funcionam os ciclos de vida em serviços injetados por injeção de dependência

## Singleton
Será criado 1 única vez e será mantido enquanto a aplicação estiver rodando.

## Scoped
Será criado 1 única vez por requisição. Logo, se o serviço for chamado em diversas classes, a instância será a mesma entre elas.

## Transient
será criado sempre que for chamado. Logo, se o serviço for chamado em diversas classes, cada uma terá uma instância diferente.
