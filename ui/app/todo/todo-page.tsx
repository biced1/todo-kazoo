import type { Todo } from "./todo";
import { TodoCard } from "./todo-card";

export function TodoPage() {
    const todoItems: Todo[] = [
        {id: 1, title: "Clean", description: "Clean the house"}, 
        {id: 1, title: "Drive", description: "Drive the car"}, 
        {id: 1, title: "Eat", description: "Eat some food"}];

    return (
        <div>
            {todoItems.map((todo) => (
                <TodoCard key={todo.id} todo={todo} />
            ))}
        </div>
    );
}
