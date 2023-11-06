1. Conteúdos da stack podem ser acedidos em qualquer altura
  Falso, porque apenas conteúdos da heap podem ser acedidos.
  
2. A stack mantém as variáveis locais
  Verdadeiro.
  
3. Os conteúdos de um tipo de valor podem estar na heap
  Verdadeiro.

4. Os conteúdos de um tipo de valor estão sempre na heap
  Falso, os conteúdos estão onde a variável está.
  
5. Os conteúdos de um tipo de referência estão sempre na heap
  Verdadeiro.

6. O garbage collector limpa memória tanto na stack como na heap
  Falso, porque o GC apenas limpa a memória na heap.

7. Podemos atribuir null a tipos de valor
  Falso, porque variáveis com tipos de valor não podem ser nulas.

8. Tendo dois tipos de referência a e b a apontar para o mesmo objeto, modificar os conteúdos de a vai também alterar os conteúdos de b
  Verdadeiro.
  
9. Tendo dois tipos de valor a e b com o mesmo valor, modificar a vai também alterar b
  Falso, porque quando o valor a é alterado apenas esse valor é alterado.